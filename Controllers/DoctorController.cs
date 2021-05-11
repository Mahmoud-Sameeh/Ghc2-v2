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

namespace GHC2.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignInManager<IdentityUser> _SignInManager { get; }
        public UserManager<IdentityUser> _UserManager { get; }
        public RoleManager<IdentityRole> _RoleManager { get; }


        public DoctorController(ApplicationDbContext context, SignInManager<IdentityUser> SignInManager
                                , UserManager<IdentityUser> UserManager, RoleManager<IdentityRole> RoleManager)
        {
            _context = context;
            _SignInManager = SignInManager;
            _UserManager = UserManager;
            _RoleManager = RoleManager;
        }

        // GET: Admins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctors.ToListAsync());
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Doctors
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
        public async Task<IActionResult> Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                // userName in identity = Nid in admin

                var role = _RoleManager.Roles.Where(e => e.Name == "Doctor").FirstOrDefault();
                if (role == null)
                {
                    role = new IdentityRole
                    {
                        Name = "Doctor"
                    };
                    await _RoleManager.CreateAsync(role);
                }
                var user = new IdentityUser
                {
                    UserName = doctor.Nid.ToString(),
                    Email = doctor.Email,
                    PhoneNumber = doctor.Phone.ToString()
                };
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                await _UserManager.CreateAsync(user, doctor.Password);

                user = _UserManager.Users.Where(e => e.UserName == user.UserName).FirstOrDefault();
                await _UserManager.AddToRoleAsync(user, "Doctor");

                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Doctors.FindAsync(id);
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
        public async Task<IActionResult> Edit(long id,Doctor doctor)
        {
            if (id != doctor.Nid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = _UserManager.Users.Where(u => u.UserName == doctor.Nid.ToString()).FirstOrDefault();

                    var token = await _UserManager.GeneratePasswordResetTokenAsync(user);

                    await _UserManager.ResetPasswordAsync(user, token, doctor.Password);

                    user.UserName = doctor.Nid.ToString();
                    user.Email = doctor.Email;
                    user.PhoneNumber = doctor.Phone.ToString();


                    await _UserManager.UpdateAsync(user);
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.Nid))
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
            return View(doctor);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors
                .FirstOrDefaultAsync(m => m.Nid == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var user = _UserManager.Users.Where(u => u.UserName == id.ToString()).FirstOrDefault();

            var doctor = await _context.Doctors.FindAsync(id);
            _context.Doctors.Remove(doctor);
            await _UserManager.DeleteAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(long id)
        {
            return _context.Doctors.Any(e => e.Nid == id);
        }
    }
}
