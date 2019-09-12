﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BobzBurger.Models;

namespace BobzBurger.Pages.Admin
{
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
            Recipe.Id = Id.GetValueOrDefault();
            await recipesService.SaveAsync(Recipe);
            return RedirectToPage("/Recipe", new { id = Id });
        }
    }
}