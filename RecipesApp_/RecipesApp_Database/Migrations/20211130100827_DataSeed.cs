using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesApp.Database.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "IngredientsRecepies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "IngredientsRecepies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 26, 19, 2, 0, 0, DateTimeKind.Unspecified), 3, "Ketchup1", 5.7899999618530273, 40 },
                    { 73, new DateTime(2021, 11, 10, 0, 32, 0, 0, DateTimeKind.Unspecified), 2, "Ketchup73", 49.700000762939453, 14 },
                    { 72, new DateTime(2021, 10, 16, 20, 44, 0, 0, DateTimeKind.Unspecified), 1, "Sphagetti72", 20.049999237060547, 22 },
                    { 71, new DateTime(2021, 10, 22, 4, 7, 0, 0, DateTimeKind.Unspecified), 3, "Sugar71", 7.4499998092651367, 46 },
                    { 70, new DateTime(2021, 1, 14, 20, 41, 0, 0, DateTimeKind.Unspecified), 4, "Meat70", 20.360000610351562, 2 },
                    { 69, new DateTime(2021, 11, 7, 15, 32, 0, 0, DateTimeKind.Unspecified), 4, "Green salad69", 29.760000228881836, 12 },
                    { 68, new DateTime(2021, 11, 27, 3, 2, 0, 0, DateTimeKind.Unspecified), 4, "Cheeze68", 41.450000762939453, 41 },
                    { 67, new DateTime(2021, 3, 14, 0, 37, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup67", 43.150001525878906, 32 },
                    { 66, new DateTime(2021, 10, 7, 2, 1, 0, 0, DateTimeKind.Unspecified), 3, "Sphagetti66", 38.819999694824219, 24 },
                    { 65, new DateTime(2021, 10, 23, 10, 56, 0, 0, DateTimeKind.Unspecified), 2, "Sugar65", 39.869998931884766, 39 },
                    { 64, new DateTime(2021, 4, 4, 21, 27, 0, 0, DateTimeKind.Unspecified), 1, "Meat64", 47.069999694824219, 45 },
                    { 63, new DateTime(2021, 5, 15, 6, 43, 0, 0, DateTimeKind.Unspecified), 1, "Green salad63", 12.770000457763672, 40 },
                    { 62, new DateTime(2021, 9, 17, 13, 25, 0, 0, DateTimeKind.Unspecified), 2, "Cheeze62", 17.379999160766602, 33 },
                    { 61, new DateTime(2021, 7, 30, 9, 7, 0, 0, DateTimeKind.Unspecified), 3, "Ketchup61", 44.299999237060547, 27 },
                    { 60, new DateTime(2021, 1, 31, 8, 5, 0, 0, DateTimeKind.Unspecified), 3, "Sphagetti60", 16.540000915527344, 8 },
                    { 59, new DateTime(2021, 11, 7, 18, 58, 0, 0, DateTimeKind.Unspecified), 1, "Sugar59", 14.890000343322754, 43 },
                    { 58, new DateTime(2021, 3, 21, 8, 35, 0, 0, DateTimeKind.Unspecified), 2, "Meat58", 38.200000762939453, 10 },
                    { 57, new DateTime(2021, 4, 12, 17, 18, 0, 0, DateTimeKind.Unspecified), 1, "Green salad57", 4.8000001907348633, 37 },
                    { 56, new DateTime(2021, 6, 20, 15, 40, 0, 0, DateTimeKind.Unspecified), 2, "Cheeze56", 48.950000762939453, 14 },
                    { 55, new DateTime(2021, 9, 13, 3, 10, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup55", 8.7299995422363281, 31 },
                    { 54, new DateTime(2021, 5, 1, 5, 46, 0, 0, DateTimeKind.Unspecified), 1, "Sphagetti54", 49.689998626708984, 26 },
                    { 53, new DateTime(2021, 7, 26, 8, 58, 0, 0, DateTimeKind.Unspecified), 3, "Sugar53", 7.059999942779541, 26 },
                    { 74, new DateTime(2021, 9, 14, 22, 42, 0, 0, DateTimeKind.Unspecified), 1, "Cheeze74", 38.880001068115234, 5 },
                    { 76, new DateTime(2021, 9, 20, 9, 57, 0, 0, DateTimeKind.Unspecified), 3, "Meat76", 37.560001373291016, 23 },
                    { 77, new DateTime(2021, 6, 7, 12, 58, 0, 0, DateTimeKind.Unspecified), 1, "Sugar77", 46.200000762939453, 28 },
                    { 78, new DateTime(2021, 1, 13, 19, 37, 0, 0, DateTimeKind.Unspecified), 2, "Sphagetti78", 42.229999542236328, 38 },
                    { 100, new DateTime(2021, 1, 30, 21, 32, 0, 0, DateTimeKind.Unspecified), 3, "Meat100", 37.689998626708984, 20 },
                    { 99, new DateTime(2021, 3, 28, 18, 20, 0, 0, DateTimeKind.Unspecified), 4, "Green salad99", 27.5, 42 },
                    { 98, new DateTime(2021, 7, 28, 16, 55, 0, 0, DateTimeKind.Unspecified), 4, "Cheeze98", 17.639999389648438, 7 },
                    { 97, new DateTime(2021, 6, 14, 14, 53, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup97", 48.529998779296875, 35 },
                    { 96, new DateTime(2021, 8, 18, 21, 26, 0, 0, DateTimeKind.Unspecified), 3, "Sphagetti96", 39.180000305175781, 47 },
                    { 95, new DateTime(2021, 1, 15, 4, 47, 0, 0, DateTimeKind.Unspecified), 2, "Sugar95", 3.3499999046325684, 10 },
                    { 94, new DateTime(2021, 8, 2, 23, 22, 0, 0, DateTimeKind.Unspecified), 2, "Meat94", 22.350000381469727, 17 },
                    { 93, new DateTime(2021, 3, 17, 23, 10, 0, 0, DateTimeKind.Unspecified), 4, "Green salad93", 7.5300002098083496, 16 },
                    { 92, new DateTime(2021, 6, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cheeze92", 19.969999313354492, 6 },
                    { 91, new DateTime(2021, 8, 26, 13, 59, 0, 0, DateTimeKind.Unspecified), 4, "Ketchup91", 17.850000381469727, 26 },
                    { 52, new DateTime(2021, 2, 19, 4, 7, 0, 0, DateTimeKind.Unspecified), 1, "Meat52", 3.5099999904632568, 49 },
                    { 90, new DateTime(2021, 4, 14, 18, 27, 0, 0, DateTimeKind.Unspecified), 4, "Sphagetti90", 22.329999923706055, 30 },
                    { 88, new DateTime(2021, 2, 14, 16, 1, 0, 0, DateTimeKind.Unspecified), 2, "Meat88", 38.779998779296875, 10 },
                    { 87, new DateTime(2021, 4, 25, 21, 41, 0, 0, DateTimeKind.Unspecified), 4, "Green salad87", 47.840000152587891, 30 },
                    { 86, new DateTime(2021, 10, 27, 8, 55, 0, 0, DateTimeKind.Unspecified), 3, "Cheeze86", 25.260000228881836, 19 },
                    { 85, new DateTime(2021, 6, 14, 22, 2, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup85", 49.139999389648438, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 84, new DateTime(2021, 8, 25, 11, 18, 0, 0, DateTimeKind.Unspecified), 4, "Sphagetti84", 16.829999923706055, 47 },
                    { 83, new DateTime(2021, 11, 3, 22, 49, 0, 0, DateTimeKind.Unspecified), 3, "Sugar83", 33.159999847412109, 43 },
                    { 82, new DateTime(2021, 8, 8, 22, 2, 0, 0, DateTimeKind.Unspecified), 4, "Meat82", 10.380000114440918, 42 },
                    { 81, new DateTime(2021, 7, 17, 3, 51, 0, 0, DateTimeKind.Unspecified), 1, "Green salad81", 35.430000305175781, 6 },
                    { 80, new DateTime(2021, 8, 11, 13, 25, 0, 0, DateTimeKind.Unspecified), 3, "Cheeze80", 44.490001678466797, 27 },
                    { 79, new DateTime(2021, 5, 24, 10, 50, 0, 0, DateTimeKind.Unspecified), 2, "Ketchup79", 42.080001831054688, 6 },
                    { 89, new DateTime(2021, 2, 28, 23, 16, 0, 0, DateTimeKind.Unspecified), 2, "Sugar89", 5.2199997901916504, 24 },
                    { 51, new DateTime(2021, 1, 25, 11, 56, 0, 0, DateTimeKind.Unspecified), 3, "Green salad51", 6.0799999237060547, 12 },
                    { 75, new DateTime(2021, 4, 17, 7, 11, 0, 0, DateTimeKind.Unspecified), 1, "Green salad75", 41.619998931884766, 3 },
                    { 49, new DateTime(2021, 8, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 3, "Ketchup49", 48.759998321533203, 46 },
                    { 23, new DateTime(2021, 3, 5, 0, 54, 0, 0, DateTimeKind.Unspecified), 4, "Sugar23", 1.3200000524520874, 17 },
                    { 22, new DateTime(2021, 5, 9, 3, 21, 0, 0, DateTimeKind.Unspecified), 1, "Meat22", 17.690000534057617, 22 },
                    { 21, new DateTime(2021, 8, 18, 7, 34, 0, 0, DateTimeKind.Unspecified), 4, "Green salad21", 37.310001373291016, 3 },
                    { 20, new DateTime(2021, 9, 21, 18, 4, 0, 0, DateTimeKind.Unspecified), 2, "Cheeze20", 33.930000305175781, 5 },
                    { 19, new DateTime(2021, 5, 30, 12, 37, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup19", 45.049999237060547, 9 },
                    { 18, new DateTime(2021, 8, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sphagetti18", 24.069999694824219, 10 },
                    { 17, new DateTime(2021, 1, 12, 14, 52, 0, 0, DateTimeKind.Unspecified), 4, "Sugar17", 18.290000915527344, 34 },
                    { 16, new DateTime(2021, 8, 11, 5, 43, 0, 0, DateTimeKind.Unspecified), 4, "Meat16", 8.4200000762939453, 45 },
                    { 15, new DateTime(2021, 1, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), 3, "Green salad15", 26.459999084472656, 45 },
                    { 13, new DateTime(2021, 11, 9, 5, 28, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup13", 23.340000152587891, 37 },
                    { 24, new DateTime(2021, 5, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 4, "Sphagetti24", 2.2799999713897705, 17 },
                    { 12, new DateTime(2021, 8, 25, 22, 25, 0, 0, DateTimeKind.Unspecified), 2, "Sphagetti12", 14.680000305175781, 36 },
                    { 10, new DateTime(2021, 11, 8, 23, 59, 0, 0, DateTimeKind.Unspecified), 4, "Meat10", 9.9399995803833008, 4 },
                    { 9, new DateTime(2021, 10, 11, 7, 26, 0, 0, DateTimeKind.Unspecified), 3, "Green salad9", 46.919998168945312, 46 },
                    { 8, new DateTime(2021, 6, 6, 22, 39, 0, 0, DateTimeKind.Unspecified), 1, "Cheeze8", 45.069999694824219, 38 },
                    { 7, new DateTime(2021, 4, 26, 5, 31, 0, 0, DateTimeKind.Unspecified), 4, "Ketchup7", 1.4700000286102295, 34 },
                    { 6, new DateTime(2021, 7, 23, 3, 54, 0, 0, DateTimeKind.Unspecified), 2, "Sphagetti6", 15.5, 13 },
                    { 5, new DateTime(2021, 1, 10, 14, 6, 0, 0, DateTimeKind.Unspecified), 1, "Sugar5", 48.959999084472656, 27 },
                    { 4, new DateTime(2021, 6, 7, 17, 56, 0, 0, DateTimeKind.Unspecified), 2, "Meat4", 30.389999389648438, 46 },
                    { 3, new DateTime(2021, 7, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 4, "Green salad3", 35.119998931884766, 21 },
                    { 2, new DateTime(2021, 6, 14, 18, 13, 0, 0, DateTimeKind.Unspecified), 3, "Cheeze2", 13.850000381469727, 47 },
                    { 50, new DateTime(2021, 4, 29, 4, 37, 0, 0, DateTimeKind.Unspecified), 3, "Cheeze50", 43.569999694824219, 10 },
                    { 11, new DateTime(2021, 9, 26, 8, 41, 0, 0, DateTimeKind.Unspecified), 2, "Sugar11", 49.200000762939453, 42 },
                    { 25, new DateTime(2021, 6, 28, 22, 57, 0, 0, DateTimeKind.Unspecified), 3, "Ketchup25", 15.210000038146973, 48 },
                    { 14, new DateTime(2021, 9, 11, 1, 40, 0, 0, DateTimeKind.Unspecified), 4, "Cheeze14", 34.770000457763672, 45 },
                    { 48, new DateTime(2021, 4, 15, 20, 44, 0, 0, DateTimeKind.Unspecified), 4, "Sphagetti48", 49.869998931884766, 15 },
                    { 26, new DateTime(2021, 11, 8, 6, 1, 0, 0, DateTimeKind.Unspecified), 2, "Cheeze26", 49.060001373291016, 45 },
                    { 47, new DateTime(2021, 4, 25, 2, 10, 0, 0, DateTimeKind.Unspecified), 4, "Sugar47", 19.879999160766602, 26 },
                    { 46, new DateTime(2021, 10, 16, 9, 31, 0, 0, DateTimeKind.Unspecified), 1, "Meat46", 7.5500001907348633, 20 },
                    { 45, new DateTime(2021, 11, 5, 23, 34, 0, 0, DateTimeKind.Unspecified), 3, "Green salad45", 47.470001220703125, 38 },
                    { 44, new DateTime(2021, 2, 20, 5, 17, 0, 0, DateTimeKind.Unspecified), 1, "Cheeze44", 46.680000305175781, 9 },
                    { 43, new DateTime(2021, 10, 30, 14, 23, 0, 0, DateTimeKind.Unspecified), 4, "Ketchup43", 12.369999885559082, 22 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 42, new DateTime(2021, 10, 26, 21, 36, 0, 0, DateTimeKind.Unspecified), 2, "Sphagetti42", 1.5, 31 },
                    { 40, new DateTime(2021, 8, 13, 13, 54, 0, 0, DateTimeKind.Unspecified), 4, "Meat40", 20.760000228881836, 34 },
                    { 39, new DateTime(2021, 9, 2, 7, 27, 0, 0, DateTimeKind.Unspecified), 2, "Green salad39", 45.290000915527344, 6 },
                    { 38, new DateTime(2021, 2, 24, 18, 8, 0, 0, DateTimeKind.Unspecified), 3, "Cheeze38", 12.5, 11 },
                    { 37, new DateTime(2021, 9, 18, 1, 36, 0, 0, DateTimeKind.Unspecified), 2, "Ketchup37", 19.75, 17 },
                    { 41, new DateTime(2021, 6, 7, 10, 52, 0, 0, DateTimeKind.Unspecified), 3, "Sugar41", 35.549999237060547, 46 },
                    { 27, new DateTime(2021, 11, 21, 18, 46, 0, 0, DateTimeKind.Unspecified), 4, "Green salad27", 7.7100000381469727, 9 },
                    { 35, new DateTime(2021, 10, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4, "Sugar35", 20.649999618530273, 21 },
                    { 34, new DateTime(2021, 11, 11, 2, 26, 0, 0, DateTimeKind.Unspecified), 4, "Meat34", 48.099998474121094, 17 },
                    { 33, new DateTime(2021, 6, 14, 21, 47, 0, 0, DateTimeKind.Unspecified), 2, "Green salad33", 35.590000152587891, 40 },
                    { 32, new DateTime(2021, 11, 18, 6, 40, 0, 0, DateTimeKind.Unspecified), 4, "Cheeze32", 36.479999542236328, 1 },
                    { 31, new DateTime(2021, 1, 17, 13, 3, 0, 0, DateTimeKind.Unspecified), 1, "Ketchup31", 43.520000457763672, 33 },
                    { 30, new DateTime(2021, 7, 9, 9, 59, 0, 0, DateTimeKind.Unspecified), 4, "Sphagetti30", 18.360000610351562, 15 },
                    { 29, new DateTime(2021, 1, 23, 15, 56, 0, 0, DateTimeKind.Unspecified), 3, "Sugar29", 19.569999694824219, 3 },
                    { 28, new DateTime(2021, 7, 7, 16, 5, 0, 0, DateTimeKind.Unspecified), 4, "Meat28", 30.809999465942383, 47 },
                    { 36, new DateTime(2021, 1, 8, 7, 18, 0, 0, DateTimeKind.Unspecified), 1, "Sphagetti36", 26.799999237060547, 28 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "UserID" },
                values: new object[,]
                {
                    { 66, new DateTime(2021, 1, 22, 3, 50, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread66", "Sendwich66", 6.816357217643576, 2 },
                    { 67, new DateTime(2021, 2, 20, 1, 11, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!67", "Broccoli Salad67", 45.242638737076263, 2 },
                    { 68, new DateTime(2021, 4, 4, 6, 11, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.68", "Macarons68", 46.839730650577572, 2 },
                    { 69, new DateTime(2021, 2, 3, 18, 40, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).69", "Grilled chicken69", 25.512391799368146, 2 },
                    { 74, new DateTime(2021, 2, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread74", "Sendwich74", 89.828082087835341, 2 },
                    { 71, new DateTime(2021, 3, 15, 13, 41, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.71", "VegetarianDish71", 69.751155830338206, 2 },
                    { 72, new DateTime(2021, 1, 19, 17, 11, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.72", "Sphageti72", 71.319059503878961, 2 },
                    { 73, new DateTime(2021, 3, 31, 13, 21, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.73", "Pizza73", 29.502132087248437, 2 },
                    { 65, new DateTime(2021, 7, 24, 10, 27, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.65", "Pizza65", 64.950892782281571, 2 },
                    { 70, new DateTime(2021, 2, 10, 6, 54, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.70", "Mascarpone Mashed Potatoes70", 13.648046205122045, 2 },
                    { 64, new DateTime(2021, 9, 3, 6, 25, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.64", "Sphageti64", 54.507111166374344, 2 },
                    { 53, new DateTime(2021, 7, 8, 0, 57, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).53", "Grilled chicken53", 18.458265085918022, 2 },
                    { 62, new DateTime(2021, 8, 13, 2, 58, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.62", "Mascarpone Mashed Potatoes62", 52.59297811546967, 2 },
                    { 61, new DateTime(2021, 1, 19, 2, 19, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).61", "Grilled chicken61", 33.297746390242942, 2 },
                    { 60, new DateTime(2021, 7, 13, 5, 32, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.60", "Macarons60", 50.366319947115294, 2 },
                    { 59, new DateTime(2021, 6, 12, 6, 50, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!59", "Broccoli Salad59", 35.382330618045444, 2 },
                    { 58, new DateTime(2021, 4, 25, 18, 39, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread58", "Sendwich58", 21.816001230765135, 2 },
                    { 57, new DateTime(2021, 5, 2, 20, 3, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.57", "Pizza57", 67.011336966888663, 2 },
                    { 56, new DateTime(2021, 10, 9, 12, 58, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.56", "Sphageti56", 40.431508270293243, 2 },
                    { 55, new DateTime(2021, 9, 29, 1, 11, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.55", "VegetarianDish55", 48.911311892285624, 2 },
                    { 54, new DateTime(2021, 6, 26, 20, 15, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.54", "Mascarpone Mashed Potatoes54", 70.386798428551671, 2 },
                    { 75, new DateTime(2021, 8, 14, 12, 48, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!75", "Broccoli Salad75", 83.615380190599424, 2 },
                    { 63, new DateTime(2021, 5, 28, 5, 35, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.63", "VegetarianDish63", 34.219983500530937, 2 },
                    { 76, new DateTime(2021, 10, 19, 1, 11, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.76", "Macarons76", 15.144347717587067, 2 },
                    { 100, new DateTime(2021, 6, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.100", "Macarons100", 47.71395063014419, 2 },
                    { 78, new DateTime(2021, 8, 5, 21, 38, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.78", "Mascarpone Mashed Potatoes78", 98.309087880099696, 2 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "UserID" },
                values: new object[,]
                {
                    { 52, new DateTime(2021, 7, 24, 18, 52, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.52", "Macarons52", 84.433282096606348, 2 },
                    { 99, new DateTime(2021, 2, 21, 23, 50, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!99", "Broccoli Salad99", 1.1870469791754368, 2 },
                    { 98, new DateTime(2021, 1, 24, 21, 36, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread98", "Sendwich98", 73.497972225536586, 2 },
                    { 97, new DateTime(2021, 10, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.97", "Pizza97", 42.173124071756902, 2 },
                    { 96, new DateTime(2021, 2, 6, 2, 49, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.96", "Sphageti96", 31.004546809477986, 2 },
                    { 95, new DateTime(2021, 1, 9, 10, 21, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.95", "VegetarianDish95", 26.147692447597016, 2 },
                    { 94, new DateTime(2021, 8, 22, 21, 16, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.94", "Mascarpone Mashed Potatoes94", 39.535626605868167, 2 },
                    { 93, new DateTime(2021, 1, 26, 22, 24, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).93", "Grilled chicken93", 80.914637442172804, 2 },
                    { 92, new DateTime(2021, 4, 5, 7, 39, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.92", "Macarons92", 68.023302346478829, 2 },
                    { 91, new DateTime(2021, 7, 13, 7, 57, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!91", "Broccoli Salad91", 33.715790742410249, 2 },
                    { 77, new DateTime(2021, 1, 14, 4, 16, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).77", "Grilled chicken77", 43.909602461340654, 2 },
                    { 90, new DateTime(2021, 9, 3, 8, 15, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread90", "Sendwich90", 30.839692983701681, 2 },
                    { 88, new DateTime(2021, 9, 11, 21, 49, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.88", "Sphageti88", 67.581492284583618, 2 },
                    { 87, new DateTime(2021, 5, 4, 20, 16, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.87", "VegetarianDish87", 26.85544275346, 2 },
                    { 86, new DateTime(2021, 9, 30, 16, 23, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.86", "Mascarpone Mashed Potatoes86", 56.835440803242584, 2 },
                    { 85, new DateTime(2021, 4, 6, 17, 48, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).85", "Grilled chicken85", 55.372116974728236, 2 },
                    { 84, new DateTime(2021, 9, 11, 21, 34, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.84", "Macarons84", 98.429874218734852, 2 },
                    { 83, new DateTime(2021, 8, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!83", "Broccoli Salad83", 85.578378965881825, 2 },
                    { 82, new DateTime(2021, 5, 8, 20, 36, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread82", "Sendwich82", 75.526668161864706, 2 },
                    { 81, new DateTime(2021, 6, 22, 1, 32, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.81", "Pizza81", 91.193057380240901, 2 },
                    { 80, new DateTime(2021, 8, 30, 5, 10, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.80", "Sphageti80", 10.953359435756392, 2 },
                    { 79, new DateTime(2021, 5, 15, 13, 10, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.79", "VegetarianDish79", 53.245887837487224, 2 },
                    { 89, new DateTime(2021, 1, 31, 5, 17, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.89", "Pizza89", 58.200418841187108, 2 },
                    { 51, new DateTime(2021, 8, 10, 21, 5, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!51", "Broccoli Salad51", 61.046256213470478, 2 },
                    { 50, new DateTime(2021, 3, 25, 3, 47, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread50", "Sendwich50", 28.316832421960697, 2 },
                    { 49, new DateTime(2021, 7, 18, 0, 51, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.49", "Pizza49", 53.928143819294938, 2 },
                    { 22, new DateTime(2021, 10, 10, 8, 18, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.22", "Mascarpone Mashed Potatoes22", 54.033440507963974, 2 },
                    { 21, new DateTime(2021, 2, 18, 18, 55, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).21", "Grilled chicken21", 79.20883539747858, 2 },
                    { 20, new DateTime(2021, 6, 3, 18, 35, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.20", "Macarons20", 14.336683252051792, 2 },
                    { 19, new DateTime(2021, 2, 27, 14, 59, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!19", "Broccoli Salad19", 80.914370619652033, 2 },
                    { 18, new DateTime(2021, 7, 4, 16, 10, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread18", "Sendwich18", 82.086300103499696, 2 },
                    { 17, new DateTime(2021, 7, 26, 22, 26, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.17", "Pizza17", 12.727346783842588, 2 },
                    { 16, new DateTime(2021, 10, 10, 15, 59, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.16", "Sphageti16", 64.594816645884336, 2 },
                    { 15, new DateTime(2021, 1, 24, 10, 55, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.15", "VegetarianDish15", 26.947868261927677, 2 },
                    { 14, new DateTime(2021, 8, 17, 15, 54, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.14", "Mascarpone Mashed Potatoes14", 21.654421421072641, 2 },
                    { 13, new DateTime(2021, 3, 4, 12, 40, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).13", "Grilled chicken13", 16.682092818749179, 2 },
                    { 12, new DateTime(2021, 5, 29, 19, 16, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.12", "Macarons12", 75.346905954809344, 2 },
                    { 11, new DateTime(2021, 1, 2, 1, 5, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!11", "Broccoli Salad11", 79.282445105855558, 2 },
                    { 10, new DateTime(2021, 1, 18, 21, 44, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread10", "Sendwich10", 41.233409329426202, 2 },
                    { 9, new DateTime(2021, 8, 19, 21, 20, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.9", "Pizza9", 30.686050925257639, 2 },
                    { 8, new DateTime(2021, 6, 2, 6, 57, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.8", "Sphageti8", 36.586853505385506, 2 },
                    { 7, new DateTime(2021, 10, 30, 15, 54, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.7", "VegetarianDish7", 48.106346895036452, 2 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "UserID" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 2, 17, 12, 36, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.6", "Mascarpone Mashed Potatoes6", 7.6032573113233122, 2 },
                    { 5, new DateTime(2021, 10, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).5", "Grilled chicken5", 56.396548599655063, 2 },
                    { 4, new DateTime(2021, 3, 30, 8, 14, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.4", "Macarons4", 94.942752887468203, 2 },
                    { 3, new DateTime(2021, 4, 1, 22, 25, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!3", "Broccoli Salad3", 78.113512278587336, 2 },
                    { 2, new DateTime(2021, 9, 21, 3, 59, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread2", "Sendwich2", 58.234422908739383, 2 },
                    { 23, new DateTime(2021, 5, 22, 7, 55, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.23", "VegetarianDish23", 78.095856745771997, 2 },
                    { 24, new DateTime(2021, 11, 5, 3, 45, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.24", "Sphageti24", 79.118909847977989, 2 },
                    { 1, new DateTime(2021, 8, 20, 21, 16, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.1", "Pizza1", 42.907251729586747, 2 },
                    { 26, new DateTime(2021, 4, 9, 1, 57, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread26", "Sendwich26", 84.247832347754311, 2 },
                    { 25, new DateTime(2021, 9, 16, 1, 24, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.25", "Pizza25", 71.960769381821507, 2 },
                    { 48, new DateTime(2021, 8, 22, 13, 40, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.48", "Sphageti48", 43.494505024279704, 2 },
                    { 47, new DateTime(2021, 9, 16, 0, 25, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.47", "VegetarianDish47", 84.040552634764722, 2 },
                    { 46, new DateTime(2021, 1, 17, 20, 13, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.46", "Mascarpone Mashed Potatoes46", 93.567442945003251, 2 },
                    { 45, new DateTime(2021, 6, 23, 14, 34, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).45", "Grilled chicken45", 23.687065779551428, 2 },
                    { 44, new DateTime(2021, 9, 14, 10, 17, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.44", "Macarons44", 14.191276085186413, 2 },
                    { 43, new DateTime(2021, 9, 27, 4, 2, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!43", "Broccoli Salad43", 11.391198152392729, 2 },
                    { 41, new DateTime(2021, 9, 18, 5, 47, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.41", "Pizza41", 88.089300599922097, 2 },
                    { 40, new DateTime(2021, 1, 27, 12, 41, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.40", "Sphageti40", 56.063614598039358, 2 },
                    { 39, new DateTime(2021, 4, 6, 2, 49, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.39", "VegetarianDish39", 74.721151475664769, 2 },
                    { 38, new DateTime(2021, 7, 8, 5, 15, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.38", "Mascarpone Mashed Potatoes38", 45.585663495392382, 2 },
                    { 42, new DateTime(2021, 3, 31, 17, 43, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread42", "Sendwich42", 94.299826443800626, 2 },
                    { 36, new DateTime(2021, 11, 12, 4, 0, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.36", "Macarons36", 78.383291884969594, 2 },
                    { 35, new DateTime(2021, 7, 14, 21, 14, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!35", "Broccoli Salad35", 28.275465428491806, 2 },
                    { 34, new DateTime(2021, 10, 29, 6, 29, 0, 0, DateTimeKind.Unspecified), "Our cheat's Japanese katsu sando with crunchy slaw is the ultimate lunch treat. We love the combination of crispy chicken and soft white bread34", "Sendwich34", 49.749849741230648, 2 },
                    { 27, new DateTime(2021, 1, 30, 10, 16, 0, 0, DateTimeKind.Unspecified), "Broccoli salad is a classic summer cookout dish, but the traditional recipe is loaded up with sugar, ample mayo, bacon, and cheese. My recipe is a fresher, healthier version – I nix the sugar, meat, and cheese altogether – and the result is a crisp, refreshing, tangy dish that’ll be the star of your cookouts all summer long!27", "Broccoli Salad27", 46.922958750707544, 2 },
                    { 33, new DateTime(2021, 4, 9, 18, 5, 0, 0, DateTimeKind.Unspecified), "Mix the dough ingredients together by hand or use a hand-held or stand mixer. Do this in steps as described in the written recipe below.Knead by hand or beat the dough with your mixer.I like doing this by hand and you can watch me in the video.Place dough into a greased mixing bowl,cover tightly,and set aside to rise for about 90 minutes or overnight in the refrigerator.Punch down risen dough to release air bubbles.Divide in 2.Roll dough out into a 12 - inch circle.Cover and rest as you prep the pizza toppings.Top with favorite pizza toppings.Bake pizza at a very high temperature for only about 15 minutes.33", "Pizza33", 75.470602373811701, 2 },
                    { 32, new DateTime(2021, 11, 8, 21, 14, 0, 0, DateTimeKind.Unspecified), "In a large pot of boiling salted water, cook spaghetti according to package instructions. Drain. In a large bowl,combine beef with bread crumbs,parsley,Parmesan,egg,Mix until just combined then form into 16 balls.In a large pot over medium heat,heat oil.Add meatballs and cook,turning occasionally,until browned on all sides, about 10 minutes.Transfer meatballs to a plate.32", "Sphageti32", 68.609800249622111, 2 },
                    { 31, new DateTime(2021, 5, 26, 11, 16, 0, 0, DateTimeKind.Unspecified), "Unknown foods and exciting flavors. So this Thanksgiving, we're recreating that initial sense of wonderment by taking traditional Thanksgiving dinner in the other direction — and introducing exciting side dishes from the Old World into an otherwise familiar Thanksgiving repertoire. Come along.Mascarpone is the pride of Lombardy,Italy.A little mascarpone in the mashers is a delicious alternative to regular mashed potatoes, says Chef John. They're not too rich, but just rich enough, and perfect for any special occasion.31", "VegetarianDish31", 90.293506498585231, 2 },
                    { 30, new DateTime(2021, 11, 14, 14, 54, 0, 0, DateTimeKind.Unspecified), "Combine warm water, yeast, and sugar in a small bowl; let stand until mixture bubbles, about 5 minutes.Beat warm milk, honey, egg, and 1/2 cup of the melted butter with a heavy-duty electric stand mixer on medium speed until well blended. Add yeast mixture and salt; beat until combined. With mixer running, gradually add flour until well combined.Transfer dough to a bowl coated with cooking spray. Cover with plastic wrap, and chill 8 hours or overnight.30", "Mascarpone Mashed Potatoes30", 8.0978344893538559, 2 },
                    { 29, new DateTime(2021, 1, 6, 1, 22, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).29", "Grilled chicken29", 16.231984114848071, 2 },
                    { 28, new DateTime(2021, 3, 20, 12, 56, 0, 0, DateTimeKind.Unspecified), "In the bowl of a food processor, combine the powdered sugar, almond flour, and ½ teaspoon of salt, and process on low speed, until extra fine. Sift the almond flour mixture through a fine-mesh sieve into a large bowl.In a separate large bowl,beat the egg whites and the remaining ½ teaspoon of salt with an electric hand mixer until soft peaks form.Gradually add the granulated sugar until fully incorporated.Continue to beat until stiff peaks form(you should be able to turn the bowl upside down without anything falling out).Add the vanilla and beat until incorporated.Add the food coloring and beat until just combined.Add about ⅓ of the sifted almond flour mixture at a time to the beaten egg whites and use a spatula to gently fold until combined.After the last addition of almond flour, continue to fold slowly until the batter falls into ribbons and you can make a figure 8 while holding the spatula up.Transfer the macaron batter into a piping bag fitted with a round tip.28", "Macarons28", 50.139237220463919, 2 },
                    { 37, new DateTime(2021, 7, 29, 2, 18, 0, 0, DateTimeKind.Unspecified), "Preheat grill to medium-high heat and cook chicken about 6 min per side. This seals the juices in keeping your chicken breasts nice and moist. The higher heat gives a nice sear adding the char from the barbecue that we all love so much!Boneless chicken breasts are very lean and can dry out easily if overcooked so be sure not to overcook. To make tender grilled chicken breasts, marinate them for about 30 minutes(I like to prep my sides while I wait).37", "Grilled chicken37", 55.070063958442802, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 65, new DateTime(2021, 8, 15, 22, 9, 0, 0, DateTimeKind.Unspecified), "Dinner recipes65" },
                    { 66, new DateTime(2021, 3, 6, 6, 38, 0, 0, DateTimeKind.Unspecified), "Lunch recipes66" },
                    { 67, new DateTime(2021, 6, 12, 20, 25, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes67" },
                    { 72, new DateTime(2021, 6, 26, 12, 21, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes72" },
                    { 69, new DateTime(2021, 3, 24, 1, 1, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes69" },
                    { 70, new DateTime(2021, 3, 25, 23, 31, 0, 0, DateTimeKind.Unspecified), "Dessert recipes70" },
                    { 71, new DateTime(2021, 8, 17, 18, 13, 0, 0, DateTimeKind.Unspecified), "Holiday recipes71" },
                    { 64, new DateTime(2021, 5, 18, 12, 49, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes64" },
                    { 68, new DateTime(2021, 6, 4, 8, 27, 0, 0, DateTimeKind.Unspecified), "Main-course recipes68" },
                    { 63, new DateTime(2021, 2, 8, 16, 21, 0, 0, DateTimeKind.Unspecified), "Holiday recipes63" }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 52, new DateTime(2021, 9, 24, 19, 29, 0, 0, DateTimeKind.Unspecified), "Main-course recipes52" },
                    { 61, new DateTime(2021, 7, 6, 17, 38, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes61" },
                    { 60, new DateTime(2021, 2, 12, 13, 23, 0, 0, DateTimeKind.Unspecified), "Main-course recipes60" },
                    { 59, new DateTime(2021, 4, 1, 13, 52, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes59" },
                    { 58, new DateTime(2021, 9, 9, 8, 6, 0, 0, DateTimeKind.Unspecified), "Lunch recipes58" },
                    { 57, new DateTime(2021, 6, 26, 19, 22, 0, 0, DateTimeKind.Unspecified), "Dinner recipes57" },
                    { 56, new DateTime(2021, 7, 9, 0, 18, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes56" },
                    { 55, new DateTime(2021, 7, 17, 17, 11, 0, 0, DateTimeKind.Unspecified), "Holiday recipes55" },
                    { 54, new DateTime(2021, 4, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), "Dessert recipes54" },
                    { 53, new DateTime(2021, 10, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes53" },
                    { 73, new DateTime(2021, 5, 30, 8, 36, 0, 0, DateTimeKind.Unspecified), "Dinner recipes73" },
                    { 62, new DateTime(2021, 10, 29, 2, 25, 0, 0, DateTimeKind.Unspecified), "Dessert recipes62" },
                    { 74, new DateTime(2021, 6, 13, 16, 34, 0, 0, DateTimeKind.Unspecified), "Lunch recipes74" },
                    { 86, new DateTime(2021, 6, 12, 23, 33, 0, 0, DateTimeKind.Unspecified), "Dessert recipes86" },
                    { 76, new DateTime(2021, 11, 27, 16, 55, 0, 0, DateTimeKind.Unspecified), "Main-course recipes76" },
                    { 51, new DateTime(2021, 10, 5, 6, 50, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes51" },
                    { 98, new DateTime(2021, 8, 14, 4, 37, 0, 0, DateTimeKind.Unspecified), "Lunch recipes98" },
                    { 97, new DateTime(2021, 5, 7, 19, 3, 0, 0, DateTimeKind.Unspecified), "Dinner recipes97" },
                    { 96, new DateTime(2021, 9, 20, 2, 55, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes96" },
                    { 95, new DateTime(2021, 8, 31, 13, 11, 0, 0, DateTimeKind.Unspecified), "Holiday recipes95" },
                    { 94, new DateTime(2021, 2, 7, 21, 24, 0, 0, DateTimeKind.Unspecified), "Dessert recipes94" },
                    { 93, new DateTime(2021, 1, 18, 12, 22, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes93" },
                    { 92, new DateTime(2021, 6, 24, 8, 43, 0, 0, DateTimeKind.Unspecified), "Main-course recipes92" },
                    { 91, new DateTime(2021, 8, 25, 9, 19, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes91" },
                    { 90, new DateTime(2021, 5, 30, 4, 13, 0, 0, DateTimeKind.Unspecified), "Lunch recipes90" },
                    { 75, new DateTime(2021, 4, 7, 20, 40, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes75" },
                    { 89, new DateTime(2021, 9, 5, 20, 5, 0, 0, DateTimeKind.Unspecified), "Dinner recipes89" },
                    { 87, new DateTime(2021, 1, 2, 2, 33, 0, 0, DateTimeKind.Unspecified), "Holiday recipes87" },
                    { 85, new DateTime(2021, 9, 21, 2, 54, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes85" },
                    { 84, new DateTime(2021, 8, 8, 0, 12, 0, 0, DateTimeKind.Unspecified), "Main-course recipes84" },
                    { 83, new DateTime(2021, 2, 20, 6, 1, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes83" },
                    { 82, new DateTime(2021, 8, 14, 3, 56, 0, 0, DateTimeKind.Unspecified), "Lunch recipes82" },
                    { 81, new DateTime(2021, 7, 20, 15, 52, 0, 0, DateTimeKind.Unspecified), "Dinner recipes81" },
                    { 80, new DateTime(2021, 10, 19, 14, 23, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes80" },
                    { 79, new DateTime(2021, 4, 27, 5, 19, 0, 0, DateTimeKind.Unspecified), "Holiday recipes79" },
                    { 78, new DateTime(2021, 7, 24, 21, 42, 0, 0, DateTimeKind.Unspecified), "Dessert recipes78" },
                    { 77, new DateTime(2021, 11, 25, 15, 8, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes77" },
                    { 88, new DateTime(2021, 6, 17, 8, 56, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes88" },
                    { 50, new DateTime(2021, 1, 24, 17, 42, 0, 0, DateTimeKind.Unspecified), "Lunch recipes50" },
                    { 26, new DateTime(2021, 4, 24, 11, 7, 0, 0, DateTimeKind.Unspecified), "Lunch recipes26" },
                    { 48, new DateTime(2021, 11, 16, 17, 37, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes48" },
                    { 21, new DateTime(2021, 6, 14, 4, 20, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes21" }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 20, new DateTime(2021, 11, 25, 2, 0, 0, 0, DateTimeKind.Unspecified), "Main-course recipes20" },
                    { 19, new DateTime(2021, 9, 18, 23, 25, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes19" },
                    { 18, new DateTime(2021, 8, 18, 19, 24, 0, 0, DateTimeKind.Unspecified), "Lunch recipes18" },
                    { 17, new DateTime(2021, 10, 12, 14, 36, 0, 0, DateTimeKind.Unspecified), "Dinner recipes17" },
                    { 16, new DateTime(2021, 11, 19, 11, 4, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes16" },
                    { 15, new DateTime(2021, 6, 15, 4, 14, 0, 0, DateTimeKind.Unspecified), "Holiday recipes15" },
                    { 14, new DateTime(2021, 3, 30, 5, 32, 0, 0, DateTimeKind.Unspecified), "Dessert recipes14" },
                    { 13, new DateTime(2021, 9, 25, 21, 45, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes13" },
                    { 12, new DateTime(2021, 3, 30, 21, 41, 0, 0, DateTimeKind.Unspecified), "Main-course recipes12" },
                    { 11, new DateTime(2021, 1, 14, 2, 41, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes11" },
                    { 10, new DateTime(2021, 11, 21, 17, 13, 0, 0, DateTimeKind.Unspecified), "Lunch recipes10" },
                    { 9, new DateTime(2021, 1, 14, 22, 34, 0, 0, DateTimeKind.Unspecified), "Dinner recipes9" },
                    { 8, new DateTime(2021, 10, 9, 10, 16, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes8" },
                    { 7, new DateTime(2021, 3, 10, 3, 35, 0, 0, DateTimeKind.Unspecified), "Holiday recipes7" },
                    { 6, new DateTime(2021, 3, 9, 15, 12, 0, 0, DateTimeKind.Unspecified), "Dessert recipes6" },
                    { 5, new DateTime(2021, 6, 6, 0, 30, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes5" },
                    { 4, new DateTime(2021, 7, 18, 20, 34, 0, 0, DateTimeKind.Unspecified), "Main-course recipes4" },
                    { 3, new DateTime(2021, 5, 7, 5, 11, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes3" },
                    { 2, new DateTime(2021, 4, 26, 23, 8, 0, 0, DateTimeKind.Unspecified), "Lunch recipes2" },
                    { 1, new DateTime(2021, 8, 5, 8, 54, 0, 0, DateTimeKind.Unspecified), "Dinner recipes1" },
                    { 22, new DateTime(2021, 1, 28, 8, 35, 0, 0, DateTimeKind.Unspecified), "Dessert recipes22" },
                    { 23, new DateTime(2021, 9, 29, 3, 45, 0, 0, DateTimeKind.Unspecified), "Holiday recipes23" },
                    { 24, new DateTime(2021, 7, 26, 21, 4, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes24" },
                    { 25, new DateTime(2021, 4, 19, 6, 41, 0, 0, DateTimeKind.Unspecified), "Dinner recipes25" },
                    { 47, new DateTime(2021, 9, 2, 19, 14, 0, 0, DateTimeKind.Unspecified), "Holiday recipes47" },
                    { 46, new DateTime(2021, 5, 29, 16, 18, 0, 0, DateTimeKind.Unspecified), "Dessert recipes46" },
                    { 45, new DateTime(2021, 4, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes45" },
                    { 44, new DateTime(2021, 3, 8, 6, 3, 0, 0, DateTimeKind.Unspecified), "Main-course recipes44" },
                    { 43, new DateTime(2021, 1, 31, 17, 27, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes43" },
                    { 42, new DateTime(2021, 6, 15, 11, 24, 0, 0, DateTimeKind.Unspecified), "Lunch recipes42" },
                    { 41, new DateTime(2021, 8, 20, 5, 20, 0, 0, DateTimeKind.Unspecified), "Dinner recipes41" },
                    { 40, new DateTime(2021, 4, 8, 6, 50, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes40" },
                    { 39, new DateTime(2021, 3, 22, 10, 48, 0, 0, DateTimeKind.Unspecified), "Holiday recipes39" },
                    { 38, new DateTime(2021, 4, 19, 2, 15, 0, 0, DateTimeKind.Unspecified), "Dessert recipes38" },
                    { 49, new DateTime(2021, 2, 18, 19, 8, 0, 0, DateTimeKind.Unspecified), "Dinner recipes49" },
                    { 37, new DateTime(2021, 4, 4, 16, 50, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes37" },
                    { 35, new DateTime(2021, 1, 7, 4, 31, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes35" },
                    { 34, new DateTime(2021, 4, 24, 13, 17, 0, 0, DateTimeKind.Unspecified), "Lunch recipes34" },
                    { 33, new DateTime(2021, 9, 16, 1, 16, 0, 0, DateTimeKind.Unspecified), "Dinner recipes33" },
                    { 32, new DateTime(2021, 10, 8, 20, 3, 0, 0, DateTimeKind.Unspecified), "Breakfast recipes32" },
                    { 31, new DateTime(2021, 4, 8, 19, 3, 0, 0, DateTimeKind.Unspecified), "Holiday recipes31" },
                    { 30, new DateTime(2021, 7, 28, 9, 45, 0, 0, DateTimeKind.Unspecified), "Dessert recipes30" }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategories",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 8, 31, 17, 55, 0, 0, DateTimeKind.Unspecified), "Side-dish recipes29" },
                    { 28, new DateTime(2021, 4, 10, 1, 10, 0, 0, DateTimeKind.Unspecified), "Main-course recipes28" },
                    { 27, new DateTime(2021, 8, 1, 21, 34, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes27" },
                    { 99, new DateTime(2021, 6, 21, 7, 53, 0, 0, DateTimeKind.Unspecified), "Appetizer recipes99" },
                    { 36, new DateTime(2021, 3, 23, 4, 42, 0, 0, DateTimeKind.Unspecified), "Main-course recipes36" },
                    { 100, new DateTime(2021, 1, 27, 9, 7, 0, 0, DateTimeKind.Unspecified), "Main-course recipes100" }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 49, 1, 2, null, 0.0, 13 },
                    { 33, 74, 1, null, 0.0, 12 },
                    { 92, 69, 3, null, 0.0, 3 },
                    { 77, 68, 3, null, 0.0, 41 },
                    { 60, 68, 3, null, 0.0, 26 },
                    { 67, 68, 1, null, 0.0, 5 },
                    { 32, 68, 2, null, 0.0, 17 },
                    { 16, 66, 1, null, 0.0, 9 },
                    { 80, 66, 4, null, 0.0, 4 },
                    { 43, 66, 3, null, 0.0, 20 },
                    { 79, 66, 1, null, 0.0, 44 },
                    { 21, 65, 3, null, 0.0, 41 },
                    { 31, 64, 1, null, 0.0, 1 },
                    { 89, 64, 4, null, 0.0, 32 },
                    { 92, 62, 4, null, 0.0, 43 },
                    { 67, 62, 4, null, 0.0, 22 },
                    { 7, 61, 1, null, 0.0, 47 },
                    { 71, 60, 1, null, 0.0, 48 },
                    { 67, 56, 4, null, 0.0, 49 },
                    { 42, 56, 4, null, 0.0, 9 },
                    { 81, 55, 3, null, 0.0, 12 },
                    { 83, 55, 1, null, 0.0, 23 },
                    { 10, 74, 2, null, 0.0, 30 },
                    { 4, 55, 2, null, 0.0, 48 },
                    { 38, 75, 4, null, 0.0, 5 },
                    { 50, 76, 1, null, 0.0, 15 },
                    { 24, 97, 3, null, 0.0, 43 },
                    { 34, 97, 2, null, 0.0, 20 },
                    { 42, 95, 4, null, 0.0, 45 },
                    { 23, 94, 2, null, 0.0, 32 },
                    { 67, 94, 3, null, 0.0, 1 },
                    { 75, 93, 2, null, 0.0, 5 },
                    { 97, 92, 4, null, 0.0, 21 },
                    { 16, 92, 2, null, 0.0, 7 },
                    { 47, 92, 2, null, 0.0, 36 },
                    { 77, 89, 4, null, 0.0, 19 },
                    { 34, 88, 4, null, 0.0, 3 },
                    { 92, 88, 4, null, 0.0, 49 },
                    { 95, 85, 3, null, 0.0, 5 },
                    { 25, 84, 1, null, 0.0, 31 },
                    { 55, 83, 1, null, 0.0, 26 },
                    { 20, 80, 1, null, 0.0, 10 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 79, 80, 2, null, 0.0, 13 },
                    { 67, 80, 1, null, 0.0, 3 },
                    { 12, 79, 3, null, 0.0, 30 },
                    { 69, 77, 1, null, 0.0, 45 },
                    { 35, 76, 2, null, 0.0, 17 },
                    { 63, 76, 4, null, 0.0, 10 },
                    { 2, 54, 2, null, 0.0, 32 },
                    { 38, 98, 1, null, 0.0, 10 },
                    { 95, 52, 2, null, 0.0, 39 },
                    { 52, 27, 2, null, 0.0, 48 },
                    { 14, 26, 2, null, 0.0, 28 },
                    { 32, 24, 3, null, 0.0, 1 },
                    { 45, 23, 1, null, 0.0, 17 },
                    { 22, 22, 4, null, 0.0, 45 },
                    { 15, 22, 4, null, 0.0, 28 },
                    { 64, 21, 1, null, 0.0, 32 },
                    { 95, 19, 4, null, 0.0, 40 },
                    { 35, 54, 3, null, 0.0, 32 },
                    { 2, 16, 4, null, 0.0, 30 },
                    { 99, 15, 4, null, 0.0, 26 },
                    { 15, 15, 4, null, 0.0, 28 },
                    { 43, 11, 4, null, 0.0, 19 },
                    { 46, 9, 4, null, 0.0, 24 },
                    { 33, 8, 2, null, 0.0, 42 },
                    { 1, 5, 2, null, 0.0, 27 },
                    { 99, 4, 4, null, 0.0, 33 },
                    { 33, 3, 1, null, 0.0, 20 },
                    { 95, 3, 3, null, 0.0, 16 },
                    { 96, 2, 3, null, 0.0, 39 },
                    { 5, 1, 4, null, 0.0, 15 },
                    { 47, 28, 4, null, 0.0, 22 },
                    { 59, 29, 3, null, 0.0, 28 },
                    { 59, 18, 2, null, 0.0, 36 },
                    { 62, 30, 2, null, 0.0, 44 },
                    { 79, 30, 3, null, 0.0, 40 },
                    { 58, 50, 2, null, 0.0, 4 },
                    { 36, 49, 2, null, 0.0, 26 },
                    { 55, 49, 2, null, 0.0, 29 },
                    { 59, 48, 1, null, 0.0, 4 },
                    { 82, 48, 4, null, 0.0, 11 },
                    { 17, 47, 3, null, 0.0, 28 },
                    { 48, 46, 2, null, 0.0, 34 }
                });

            migrationBuilder.InsertData(
                table: "IngredientsRecepies",
                columns: new[] { "IngredientsId", "RecipesId", "Measure", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 98, 45, 3, null, 0.0, 39 },
                    { 84, 42, 2, null, 0.0, 32 },
                    { 20, 42, 3, null, 0.0, 5 },
                    { 98, 52, 2, null, 0.0, 41 },
                    { 71, 37, 1, null, 0.0, 6 },
                    { 53, 37, 1, null, 0.0, 2 },
                    { 86, 37, 2, null, 0.0, 16 },
                    { 29, 36, 4, null, 0.0, 49 },
                    { 72, 36, 4, null, 0.0, 47 },
                    { 81, 34, 1, null, 0.0, 11 },
                    { 99, 33, 4, null, 0.0, 10 },
                    { 5, 33, 2, null, 0.0, 10 },
                    { 9, 32, 1, null, 0.0, 3 },
                    { 92, 32, 2, null, 0.0, 14 },
                    { 14, 39, 2, null, 0.0, 47 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 63, 67 },
                    { 64, 60 },
                    { 64, 38 },
                    { 66, 15 },
                    { 64, 49 },
                    { 66, 85 },
                    { 66, 37 },
                    { 63, 12 },
                    { 64, 7 },
                    { 62, 62 },
                    { 57, 62 },
                    { 59, 69 },
                    { 59, 38 },
                    { 58, 90 },
                    { 54, 60 },
                    { 54, 45 },
                    { 52, 15 },
                    { 51, 31 },
                    { 50, 89 },
                    { 48, 4 },
                    { 60, 47 },
                    { 67, 66 },
                    { 98, 85 },
                    { 71, 38 },
                    { 47, 25 },
                    { 98, 78 },
                    { 97, 44 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 96, 21 },
                    { 95, 98 },
                    { 94, 36 },
                    { 93, 40 },
                    { 92, 95 },
                    { 90, 99 },
                    { 89, 69 },
                    { 68, 63 },
                    { 89, 28 },
                    { 85, 84 },
                    { 83, 22 },
                    { 81, 23 },
                    { 79, 96 },
                    { 79, 16 },
                    { 77, 16 },
                    { 75, 47 },
                    { 74, 50 },
                    { 73, 19 },
                    { 72, 68 },
                    { 88, 38 },
                    { 46, 3 },
                    { 24, 22 },
                    { 43, 20 },
                    { 19, 24 },
                    { 18, 94 },
                    { 18, 66 },
                    { 17, 75 },
                    { 16, 78 },
                    { 15, 16 },
                    { 15, 49 },
                    { 13, 16 },
                    { 11, 64 },
                    { 10, 15 },
                    { 9, 71 },
                    { 9, 7 },
                    { 7, 87 },
                    { 7, 36 },
                    { 6, 73 },
                    { 5, 27 },
                    { 5, 34 },
                    { 2, 23 },
                    { 1, 11 }
                });

            migrationBuilder.InsertData(
                table: "RecipesCategoryRecipes",
                columns: new[] { "RecipesCategoryId", "RecipesId" },
                values: new object[,]
                {
                    { 1, 55 },
                    { 98, 97 },
                    { 21, 30 },
                    { 22, 89 },
                    { 22, 58 },
                    { 23, 24 },
                    { 42, 19 },
                    { 38, 90 },
                    { 38, 45 },
                    { 36, 30 },
                    { 35, 45 },
                    { 31, 43 },
                    { 30, 90 },
                    { 29, 81 },
                    { 29, 32 },
                    { 29, 76 },
                    { 45, 15 },
                    { 29, 93 },
                    { 28, 91 },
                    { 28, 77 },
                    { 27, 28 },
                    { 27, 22 },
                    { 27, 25 },
                    { 26, 72 },
                    { 26, 65 },
                    { 25, 33 },
                    { 25, 56 },
                    { 25, 76 },
                    { 29, 49 },
                    { 99, 13 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 43, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 99, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 59, 18 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 95, 19 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 64, 21 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 15, 22 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 45, 23 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 32, 24 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 14, 26 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 52, 27 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 47, 28 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 59, 29 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 62, 30 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 79, 30 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 9, 32 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 32 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 5, 33 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 99, 33 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 81, 34 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 29, 36 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 72, 36 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 53, 37 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 71, 37 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 86, 37 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 14, 39 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 20, 42 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 84, 42 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 98, 45 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 48, 46 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 17, 47 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 59, 48 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 82, 48 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 36, 49 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 55, 49 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 58, 50 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 95, 52 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 98, 52 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 35, 54 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 4, 55 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 81, 55 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 83, 55 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 42, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 56 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 71, 60 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 7, 61 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 62 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 62 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 31, 64 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 89, 64 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 21, 65 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 16, 66 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 43, 66 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 79, 66 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 80, 66 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 32, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 60, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 77, 68 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 69 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 10, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 33, 74 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 38, 75 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 35, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 50, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 63, 76 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 69, 77 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 12, 79 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 20, 80 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 80 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 79, 80 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 55, 83 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 25, 84 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 95, 85 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 34, 88 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 92, 88 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 77, 89 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 16, 92 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 47, 92 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 97, 92 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 75, 93 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 23, 94 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 67, 94 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 42, 95 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 24, 97 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 34, 97 });

            migrationBuilder.DeleteData(
                table: "IngredientsRecepies",
                keyColumns: new[] { "IngredientsId", "RecipesId" },
                keyValues: new object[] { 38, 98 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 7 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 63, 12 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 99, 13 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 45, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 52, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 66, 15 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 77, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 79, 16 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 42, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 73, 19 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 43, 20 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 96, 21 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 24, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 27, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 83, 22 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 81, 23 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 19, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 23, 24 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 27, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 47, 25 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 27, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 89, 28 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 21, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 36, 30 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 51, 31 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 32 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 25, 33 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 5, 34 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 94, 36 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 66, 37 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 71, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 88, 38 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 93, 40 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 31, 43 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 97, 44 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 35, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 38, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 45 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 60, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 75, 47 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 15, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 49 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 74, 50 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 25, 56 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 22, 58 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 54, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 64, 60 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 57, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 62, 62 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 68, 63 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 11, 64 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 26, 65 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 18, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 67, 66 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 63, 67 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 72, 68 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 59, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 89, 69 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 9, 71 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 26, 72 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 6, 73 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 17, 75 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 25, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 76 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 28, 77 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 16, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 78 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 81 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 85, 84 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 66, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 85 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 7, 87 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 22, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 50, 89 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 30, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 38, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 58, 90 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 28, 91 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 29, 93 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 18, 94 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 92, 95 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 79, 96 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 98, 97 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 95, 98 });

            migrationBuilder.DeleteData(
                table: "RecipesCategoryRecipes",
                keyColumns: new[] { "RecipesCategoryId", "RecipesId" },
                keyValues: new object[] { 90, 99 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RecipesCategories",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "IngredientsRecepies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "IngredientsRecepies");
        }
    }
}
