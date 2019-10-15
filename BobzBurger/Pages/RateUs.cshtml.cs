using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using BobzBurger.Models;


namespace BobzBurger.Pages
{
    public class RateUsModel : PageModel
    {
        [FromRoute]
        public long? Id { get; set; }
        public IFormFile UserImage { get; set; }
        public Comment Comments { get; set; }
        public void OnGet()
        {

        }
    }
}