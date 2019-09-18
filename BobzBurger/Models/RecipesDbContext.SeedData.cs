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
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger2.png"),
                    ImageContentType = "image/jpeg",
                },
                new Recipe {
                    Name = "FRIED AND PREJUDICE",
                    Description = "Crispy, savory, salty. Who doesn't like fries? ",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger3.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "A BEET-CAR NAMED DESIRE",
                    Description = "It was either this of some Beet it joke.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger4.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "SWEET DREAMS ARE MADE OF CHEESE",
                    Description = "Three layers of cardiac arrest at your service!",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger5.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "AH, AH, AH, AH STAYIN' A-CHIVE",
                    Description = "Because normal onions were sold out.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger6.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "LICENSE TO KALE",
                    Description = "No Kale has been hurt in the production of this burger.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger7.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "HAM-LET",
                    Description = "I'm a huff, and I'm a puff, till your choking down this gorgeous burger.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger8.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "WAR AND PEAS",
                    Description = "This one really does become a mess to eat, but it still is very a-peas-ing.",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger9.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "THE CORN SUPREMACY",
                    Description = "Who said being corny is a bad thing?",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger10.png"),
                    ImageContentType = "image/jpeg",
                },
				                new Recipe {
                    Name = "NEW YOLK CITY",
                    Description = "Eh yo, just try it! It's Egg-squisite!",
					                    Ingredients = string.Join(Environment.NewLine, new List<string> {
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
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
                        "1/2 cup shredded carrots",
                        "1/2 cup apple, chopped into 1 inch cubes",
                        "1/2 cup oats or barley",
                        "1 cup ground beef, pork, or chicken",
                        "1 egg, slightly beaten",
                    }),
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger12.png"),
                    ImageContentType = "image/jpeg",
                },
            };
        }
    }
}

