using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BobzBurger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace BobzBurger.Pages.Admin
{
    [Authorize]
    public class AddEditRecipeModel : PageModel
    {
        private readonly IRecipesService recipesService;

        [FromRoute]
        public long? Id { get; set; }

        public bool IsNewRecipe
        {   
            get { return Id == null;  }
        }
        [BindProperty]
        public Recipe Recipe { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        public AddEditRecipeModel(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }
        public async Task OnGet()
        {
            Recipe = await recipesService.FindAsync(Id.GetValueOrDefault()) ?? new Recipe();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var recipe = await recipesService.FindAsync(Id.GetValueOrDefault()) ?? new Recipe();

            recipe.Name = Recipe.Name;
            recipe.Description = Recipe.Description;
            recipe.Ingredients = Recipe.Ingredients;
            
            if(Image != null)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    recipe.Image = stream.ToArray();
                    recipe.ImageContentType = Image.ContentType;
                }
            }

            await recipesService.SaveAsync(recipe);
            return RedirectToPage("/Recipe", new { id = recipe.Id });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await recipesService.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
    }
}