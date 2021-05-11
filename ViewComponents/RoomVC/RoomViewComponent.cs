using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GHC2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GHC2.ViewComponents.RoomVC
{
    public class RoomViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext ctx;

        public RoomViewComponent(ApplicationDbContext _ctx)
        {
            ctx = _ctx;
        }

        public IViewComponentResult Invoke()
        {
            var userid = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var chats = ctx.ChatUsers
                 .Include(x => x.Chat)
                 .Where(x => x.UserId == userid)
                 .Select(x => x.Chat)
                 .ToList();
            return View(chats);
        }
    }
   
}
