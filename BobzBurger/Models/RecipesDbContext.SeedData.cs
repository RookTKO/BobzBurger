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
                    Description = "Pampering your pet with a birthday cake is a great way to celebrate, but there are careful considerations to make when deciding to share this two-legged ritual with your four-legged friends. For instance, chocolate is dangerous when consumed by our pets, and they may have allergies or sensitivities to other ingredients typically found in cake.",
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger1.png"),
                    ImageContentType = "image/jpeg",
                },
                new Recipe {
                    Name = "SIR LANSHALLOT",
                    Description = "I thought it would be nice to break away from the traditional cake posts and share one of my favorite desserts to have during the fall. Pumpkin pie! This recipe is adapted from my grandmother’s cookbook.  She would stew her own pumpkin to make her pumpkin pies. My version uses canned pumpkin and lower fat milk, but tastes just as good as hers did growing up.",
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger2.png"),
                    ImageContentType = "image/jpeg",
                },
                new Recipe {
                    Name = "FRIED AND PREJUDICE",
                    Description = "This classic sponge cake is easy to make, but has a sophisticated taste. The raspberries and fresh whipped cream keep it light, but rich at the same time.",
                    Image = File.ReadAllBytes(@"wwwroot\Images\burger3.png"),
                    ImageContentType = "image/jpeg",
                },
            };
        }
    }
}

