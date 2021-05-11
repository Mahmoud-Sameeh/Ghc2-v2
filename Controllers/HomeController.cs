using GHC2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GHC2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace GHC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext ctx;

        public UserManager<IdentityUser> sda { get; private set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _ctx, UserManager<IdentityUser> _sda)
        {
            _logger = logger;
            ctx = _ctx;
            sda = _sda;
        }
       
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexX()
        {
            List<Chat> Chats;
            try
            {
                Chats = ctx.Chats
                   .Include(x => x.Uesrs)
                      .Where(x => x.Uesrs.Any(y => y.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value))
                  .ToList();

            }
            catch
            {
                Chats = new List<Chat>();
            }

            return View(Chats);
        }
        #region custome
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion
        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            var chat = new Chat()
            {
                Name = name,
                Type = ChatType.Room
            };
            chat.Uesrs.Add(new ChatUser
            {
                userRole = UserRole.Admin,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,


            });
            ctx.Chats.Add(chat);
            await ctx.SaveChangesAsync();
            return RedirectToAction("indexX");
        }
        public async Task<IActionResult> CreateRoomautopatient(string name)        {            var curruentuser = ctx.Patients.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value);            var otheruser = ctx.Doctors.FirstOrDefault(z => z.Name == name);            var found = ctx.Chats.FirstOrDefault(z => z.Name == curruentuser.Name + "&" + name);            if (otheruser != null && found == null)            {                var chat = new Chat()                {                    Name = curruentuser.Name + "&" + name,                    Type = ChatType.Private                };                chat.Uesrs.Add(new ChatUser                {                    userRole = UserRole.Admin,                    UserId = curruentuser.IdentityId,                });                chat.Uesrs.Add(new ChatUser                {                    userRole = UserRole.Admin,                    UserId = otheruser.IdentityId,                });
                ctx.Chats.Add(chat);
                await ctx.SaveChangesAsync();                return RedirectToAction("indexx");            }            return RedirectToAction("indexx");        }


    public async Task<IActionResult> CreateRoomauto(string name)
        {

            var curruentuser = ctx.Doctors.FirstOrDefault(z => z.IdentityId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var otheruser = ctx.Patients.FirstOrDefault(z => z.Name == name);
            var found = ctx.Chats.FirstOrDefault(z => z.Name == name + "&" + curruentuser.UserName);

            if (otheruser != null && found == null)
            {
                var chat = new Chat()
                {
                    Name = name + "&" + curruentuser.UserName,
                    Type = ChatType.Private

                };

                chat.Uesrs.Add(new ChatUser
                {
                    userRole = UserRole.Admin,
                    UserId = curruentuser.IdentityId,
                });
                chat.Uesrs.Add(new ChatUser
                {
                    userRole = UserRole.Admin,
                    UserId = otheruser.IdentityId,
                });

                ctx.Chats.Add(chat);
                await ctx.SaveChangesAsync();
                return RedirectToAction("indexx");

            }
            return RedirectToAction("indexx");



        }

        [HttpGet("{id}")]
        public IActionResult Chat(int id)
        {

            var chat = ctx.Chats
            .Include(f => f.Messages)
            .FirstOrDefault(x => x.Id == id);
            return View(chat);
        }
        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            var ChatUser = new ChatUser
            {
                ChatId = id,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,

                userRole = UserRole.Member

            };
            ctx.ChatUsers.Add(ChatUser);
            await ctx.SaveChangesAsync();
            return RedirectToAction("Chat", "Home", new { id = id });

        }


        public async Task<IActionResult> CreateMessage(int chatId, string message)
        {

            var Message = new Message()
            {
                ChatId = chatId,
                Text = message,
                // Name = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Name = User.Identity.Name,
                TimeStamp = DateTime.Now.ToLongTimeString()
            };
            ctx.Messages.Add(Message);
            await ctx.SaveChangesAsync();
            return RedirectToAction("chat", new { id = chatId });
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return RedirectToAction(nameof(HomePage));
        }

    }

}