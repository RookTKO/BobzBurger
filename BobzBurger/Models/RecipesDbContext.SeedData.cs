using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BobzBurger.Models
{
    public static class RecipesDbContextSeedData
    {
        static object synchlock = new object();
        static volatile bool seeded = false;

        public static void EnsureSeedData(this RecipesDbContext context)
        {
            if (!seeded && context.Recipes.Count() == 0)
            {
                lock (synchlock)
                {
                    if (!seeded)
                    {
                        var recipes = GenerateRecipes();
                        context.Recipes.AddRange(recipes);
                        context.SaveChanges();
                        seeded = true;
                    }
                }
            }
        }

        public static Recipe[] GenerateRecipes()
        {
            return new Recipe[] {
                new Recipe {
                    Name = "OLIVER-R TWIST",
                    Description = "Want something to kick your shoes off your tippy toes? Try this twist!",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger1.png"),
                    ImageContentType = "image/png",
                },
                new Recipe {
                    Name = "SIR LANSHALLOT",
                    Description = "One word - Extremly Tasty.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shallots",
                        "1/2 cup chevre",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1/2 cup arugula",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger2.png"),
                    ImageContentType = "image/jpeg",
                },
                new Recipe {
                    Name = "FRIED AND PREJUDICE",
                    Description = "Crispy, savory, salty. Who doesn't like fries? ",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup fried french fries",
                        "2 slices of cheese",
                        "1 burger",
                        "1 whole bun, fried"
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger3.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "A BEET-CAR NAMED DESIRE",
                    Description = "It was either this of some Beet it joke.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "2 cups grated raw peeled beets (about 2 medium beets)",
                        "3/4 cup large flake rolled oats",
                        "1/2 cup cooked lentils",
                        "1/2 cup all-purpose flour",
                        "1/2 yellow onion , finely chopped",
                        "2 cloves garlic , finely minced",
                        "1 tablespoon natural peanut butter",
                        "2 teaspoons dried thyme leaves",
                        "1/2 teaspoon salt",
                        "1/4 teaspoon black pepper",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger4.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "SWEET DREAMS ARE MADE OF CHEESE",
                    Description = "Three layers of cardiac arrest at your service!",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "8 slices thick-cut bacon",
                        "1 medium sweet yellow onion, sliced or diced",
                        "1 1/2 lbs ground beef (75 or 80% lean)",
                        "1 cup sharp cheddar cheese, shredded (Tillamook is my favorite brand)",
                        "1/4 tsp kosher salt",
                        "1/4 tsp black pepper",
                        "drizzle of olive oil",
                        "1/2 Tbsp butter",
                        "your favorite all natural barbecue sauce",
                        "4 hamburger buns, toasted (potato, sesame seed, brioche, etc)",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger5.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "AH, AH, AH, AH STAYIN' A-CHIVE",
                    Description = "Because normal onions were sold out.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "⅓ cup finely chopped fresh parsley",
                        "3 tablespoons minced fresh chives",
                        "4 large cloves garlic, minced",
                        "1¼ teaspoons salt",
                        "½ teaspoon ground black pepper",
                        "1½ cups shredded sharp Cheddar cheese",
                        "2 pounds ground beef (I used grass-fed)",
                        "6 slices Cheddar cheese (optional)",
                        "6 whole grain buns, toasted, or 6 large lettuce leaves",

                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger6.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "LICENSE TO KALE",
                    Description = "No Kale has been hurt in the production of this burger.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 lb. curly kale, about 1 small bunch or 1/2 of a large bunch",
                        "1-15 oz. can cannellini beans, drained and rinsed",
                        "1 to 1 1/4 cups panko breadcrumbs",
                        "1/2 cup roasted sunflower seeds",
                        "1/2 cup fresh basil leaves, lightly packed",
                        "4 garlic cloves, minced (or more, if you want your burger very garlicky!)",
                        "2 tbsp.lemon juice",
                        "salt and pepper to taste",
                        "oil, for grilling",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger7.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "HAM-LET",
                    Description = "I'm a huff, and I'm a puff, till your choking down this gorgeous burger.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1 1/2 pounds 80% lean 20% fat ground beef or ground chuck",
                        "1 tablespoon Worcestershire sauce",
                        "1 1/2 teaspoons seasoning salt",
                        "1 teaspoon garlic powder",
                        "1/2 teaspoon ground black pepper",
                        "Optional: 4 slices of cheese",
                        "4 hamburger buns",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger8.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "WAR AND PEAS",
                    Description = "This one really does become a mess to eat, but it still is very a-peas-ing.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "3 tablespoons extra-virgin olive oil, plus more for sautéing",
                        "1 / 2 medium yellow onion, chopped",
                        "1 cup bread crumbs, fresh or panko",
                        "2 tablespoons roughly chopped mint, plus whole leaves for garnish",
                        "2 garlic cloves, smashed and peeled",
                        "1 / 4 cup grated Asiago(or Parmesan)",
                        "1 large egg",
                        "12 ounces frozen green peas, thawed(about 2 1 / 2 cups)",
                        "Kosher salt",
                        "3 scallions, finely chopped",
                        "Freshly ground black pepper",
                        "Red pepper flakes",
                        "10 ounces baby bella mushrooms, thickly sliced",
                        "Canola oil, for frying",
                        "1 / 2 cup fresh whole - milk ricotta",
                        "4 soft burger buns, preferably potato",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger9.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "THE CORN SUPREMACY",
                    Description = "Who said being corny is a bad thing?",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "4 burger patties",
                        "4 burger buns",
                        "8 slices American cheese",
                        "The Best Guacamole",
                        "Mexican Street Corn (recipe below)",
                        "4 large ears corn, grilled(or 3 cups frozen corn kernels, thawed)",
                        "2 tablespoons mayonnaise",
                        "2 tablespoons sour cream",
                        "1 / 2 tablespoon olive oil",
                        "1 / 2 lime, zested and juiced",
                        "2 teaspoons chili powder",
                        "1 / 4 cup finely chopped cilantro",
                        "Kosher salt",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger10.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "NEW YOLK CITY",
                    Description = "Eh yo, just try it! It's Egg-squisite!",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger11.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "ADVOCADON'T WORRY, BE HAPPY",
                    Description = "If you're allergic to avocado's I would advice you advocadon't this burger.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1 1/2 tsp.  Worcestershire sauce",
                        "1 1/2 tsp.  salt",
                        "3/4 tsp.    pepper",
                        "2 lbs.  lean ground beef",
                        "1 1/2   ripe, Fresh California Avocados",
                        "Lettuce leaves as needed",
                        "2   onions, sliced",
                        "2   tomatoes, sliced",
                        "6   sesame seed burger buns",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger12.png"),
                    ImageContentType = "image/jpeg",
                },
            };
        }
    }
}

