using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XE.VSSaturday.AspNetCore.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            //HttpContext.Response.Cookies.Append(
            //        "name", 
            //        "Andrea", 
            //        new Microsoft.AspNetCore.Http.CookieOptions() 
            //        { 
            //            IsEssential = true 
            //        });
        }
    }
}
