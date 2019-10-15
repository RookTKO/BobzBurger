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

        [BindProperty]
        public string Rating { get; set; }
        public string[] Ratings = new[] { "1 Star", "2 Star", "3 Star", "4 Star", "5 Star" };
        [FromRoute]
        public long? Id { get; set; }
        public IFormFile UserImage { get; set; }
        public Comment Comments { get; set; }
        public void OnGet()
        {

        }
    }
}