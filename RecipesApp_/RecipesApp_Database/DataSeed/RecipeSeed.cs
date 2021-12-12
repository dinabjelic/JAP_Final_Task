using Microsoft.EntityFrameworkCore;
using RecipesApp.Core.Helpers;
using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;

namespace RecipesApp.Database.DataSeed
{
    public static class RecipeSeed
    {
        public static void SeedRecipes(this ModelBuilder builder)
        {
            Random random = new Random();
            List<string> recipeNames = new()
            {
                "Sphageti",
                "Pizza",
                "Sendwich",
                "Broccoli Salad",
                "Macarons",
                "Grilled chicken",
                "Mascarpone Mashed Potatoes",
                "VegetarianDish"
            };

            List<string> recipeDescription = new()
            {
                "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.",
                "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.",
                "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread",
                "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!",
                "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.",
                "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).",
                "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.",
                "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.",
            };

            List<Recipe> recipes = new();
            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for(int i=1; i<=100;i++)
            {
                recipes.Add(new Recipe
                {
                    Id = i,
                    Name = recipeNames[i % 8] + i.ToString(),
                    Price = (double)(random.Next(1, 100) + random.NextDouble()),
                    Description = recipeDescription[i%8] +i.ToString(),
                    UserID = 2,
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }

            builder.Entity<Recipe>().HasData(recipes);
        }
    }
}
