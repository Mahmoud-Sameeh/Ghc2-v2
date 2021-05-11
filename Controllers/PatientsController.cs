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
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignInManager<IdentityUser> _SignInManager { get; }
        public UserManager<IdentityUser> _UserManager { get; }
        public RoleManager<IdentityRole> _RoleManager { get; }


        public PatientsController(ApplicationDbContext context, SignInManager<IdentityUser> SignInManager
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
            return View(await _context.Patients.ToListAsync());
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Nid == id);
            if (Patient == null)
            {
                return NotFound();
            }

            return View(Patient);
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
        public async Task<IActionResult> Create([Bind("Nid,Name,Gender,BitrhDate,Address,Phone,Email,UserName,Password,ImageUrl,Position")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                // userName in identity = Nid in admin

                var role = _RoleManager.Roles.Where(e => e.Name == "Patient").FirstOrDefault();
                if (role == null)
                {
                    role = new IdentityRole
                    {
                        Name = "Patient"
                    };
                    await _RoleManager.CreateAsync(role);
                }
                var user = new IdentityUser
                {
                    UserName = patient.Nid.ToString(),
                    Email = patient.Email,
                    PhoneNumber = patient.Phone.ToString()
                };
                _context.Add(patient);
                await _context.SaveChangesAsync();
               var x= await _UserManager.CreateAsync(user, patient.Password);

              var  user1 = _UserManager.Users.Where(e => e.UserName == user.UserName).FirstOrDefault();
                await _UserManager.AddToRoleAsync(user1, "Patient");

                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id,Patient patient)
        {
            if (id != patient.Nid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = _UserManager.Users.Where(u => u.UserName == patient.Nid.ToString()).FirstOrDefault();

                    var token = await _UserManager.GeneratePasswordResetTokenAsync(user);

                    await _UserManager.ResetPasswordAsync(user, token, patient.Password);


                    user.UserName = patient.Nid.ToString();
                    user.Email = patient.Email;
                    user.PhoneNumber = patient.Phone.ToString();


                    await _UserManager.UpdateAsync(user);
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(patient.Nid))
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
            return View(patient);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Nid == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var user = _UserManager.Users.Where(u => u.UserName == id.ToString()).FirstOrDefault();

            var patient = await _context.Patients.FindAsync(id);
            _context.Patients.Remove(patient);
            await _UserManager.DeleteAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(Int64 id)
        {
            return _context.Doctors.Any(e => e.Nid == id);
        }
    }
}
