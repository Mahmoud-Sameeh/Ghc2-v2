using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GHC2.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace GHC2.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class PatientRegistrationModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly ILogger<RegisterModel> _logger;

        //     private readonly IEmailSender _emailSender;

        public PatientRegistrationModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            ApplicationDbContext db,
            RoleManager<IdentityRole> roleManager
            //   IEmailSender emailSender
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            //     _emailSender = emailSender;
            _roleManager = roleManager;
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {


            [Required]
            public string Name { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            public string SNN { get; set; }
            [Required]
            public string Gender { get; set; }
            [Required]
            public string Phone { get; set; }

            [Required]
            public string Address { get; set; }
            [Required]
            public DateTime BirthDate { get; set; }


            [Required]
            [Display(Name = "Image URL")]
            public string ImgUrl { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            //  [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            //[Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {


            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {


                var user = new IdentityUser
                {
                    UserName = Input.UserName,
                    Email = Input.Email,
                    PasswordHash = Input.Password,
                    PhoneNumber = Input.Phone,
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    // role does not exist -> create role first

                    if (await _roleManager.FindByNameAsync("Doctor") == null)
                    {
                        result = await _roleManager.CreateAsync(new IdentityRole("Doctor"));
                    }
                    //assign user to role
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Doctor");

                    }
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
