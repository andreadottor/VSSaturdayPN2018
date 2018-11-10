using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XE.VSSaturday.RazorPages.Web.Pages
{
    public class ContactModel : PageModel
    {

        [BindProperty]
        public ContactFormModel Input { get; set; }

        public class ContactFormModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.MultilineText)]
            public string Text { get; set; }
        }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                // TODO: invio della mail con il testo della form
                //
                var email = Input.Email;
                var text = Input.Text;

                return RedirectToPage("./ContactOk");

            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

    
    }
}
