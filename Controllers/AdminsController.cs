using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GHC2.Data;
using GHC2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace GHC2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignInManager<IdentityUser> _SignInManager { get; }
        public UserManager<IdentityUser> _UserManager { get; }
        public RoleManager<IdentityRole> _RoleManager { get; }


        public AdminsController(ApplicationDbContext context ,  SignInManager<IdentityUser> SignInManager
                                ,UserManager<IdentityUser> UserManager, RoleManager<IdentityRole> RoleManager)
        {
            _context = context;
            _SignInManager = SignInManager;
            _UserManager = UserManager;
            _RoleManager = RoleManager;
        }

        // GET: Admins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Admins.ToListAsync());
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .FirstOrDefaultAsync(m => m.Nid == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nid,Name,Gender,BitrhDate,Address,Phone,Email,UserName,Password,ImageUrl,Position")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                // userName in identity = Nid in admin

                var role = _RoleManager.Roles.Where(e => e.Name == "Admin").FirstOrDefault();
                if (role == null)
                {
                    role = new IdentityRole
                    {
                        Name="Admin"
                    };
                  await _RoleManager.CreateAsync(role);
                }
                var user = new IdentityUser
                {
                    UserName=admin.Nid.ToString(),
                    Email=admin.Email,
                    PhoneNumber= admin.Phone.ToString()
                };
                _context.Add(admin);
                await _context.SaveChangesAsync();
                await _UserManager.CreateAsync(user, admin.Password);

                user = _UserManager.Users.Where(e=>e.UserName==user.UserName).FirstOrDefault();
                await _UserManager.AddToRoleAsync(user,"Admin");

                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("Nid,Name,Gender,BitrhDate,Address,Phone,Email,UserName,Password,ImageUrl,Position")] Admin admin)
        {
            if (id != admin.Nid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  var user=  _UserManager.Users.Where(u => u.UserName == admin.Nid.ToString()).FirstOrDefault();

                  var token = await _UserManager.GeneratePasswordResetTokenAsync(user);

                  await _UserManager.ResetPasswordAsync(user, token, admin.Password);

                    user.UserName = admin.Nid.ToString();
                    user.Email = admin.Email;
                    user.PhoneNumber = admin.Phone.ToString();


                   await _UserManager.UpdateAsync(user);
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.Nid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .FirstOrDefaultAsync(m => m.Nid == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var user = _UserManager.Users.Where(u => u.UserName == id.ToString()).FirstOrDefault();

            var admin = await _context.Admins.FindAsync(id);
            _context.Admins.Remove(admin);
            await _UserManager.DeleteAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(Int64 id)
        {
            return _context.Admins.Any(e => e.Nid == id);
        }
    }
}
