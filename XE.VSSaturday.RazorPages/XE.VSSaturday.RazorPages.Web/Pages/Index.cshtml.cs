using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XE.VSSaturday.RazorPages.Web.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public NewsletterFormModel Input { get; set; }

        [TempData]
        public string NewsletterJoinMessage { get; set; }

        public class NewsletterFormModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostJoinListXEAsync()
        {
            if (ModelState.IsValid)
            {
                // TODO: Gestire l'iscrizione alla newsletter
                //
                this.NewsletterJoinMessage = "Sei ora iscritto alla newsletter di XE";
                return RedirectToPage("./Newsletter/Ok");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostJoinList1nn0vaAsync()
        {
            if (ModelState.IsValid)
            {
                // TODO: Gestire l'iscrizione alla newsletter
                //
                this.NewsletterJoinMessage = "Sei ora iscritto alla newsletter di 1nn0va";
                return RedirectToPage("./Newsletter/Ok");
            }

            return Page();
        }
    }
}
