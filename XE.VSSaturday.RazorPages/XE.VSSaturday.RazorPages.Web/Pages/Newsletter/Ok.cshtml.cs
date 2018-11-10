using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XE.VSSaturday.RazorPages.Web.Pages.Newsletter
{
    public class OkModel : PageModel
    {
        [TempData]
        public string NewsletterJoinMessage { get; set; }

        public void OnGet()
        {

        }
    }
}