using AutoMapper;
using RecipesApp.Core.Models;
using RecipesApp.Core.Requests;
using RecipesApp.Core.Responses;
using RecipesApp.Database.Entities;
using RecipesApp.Models;

namespace RecipesApp.Mapper
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<Recipe, AddRecipeRequest>().ReverseMap();

            CreateMap<Ingredient, GetIngredientResponse>().ReverseMap();

            CreateMap<IngredientRecipe, GetIngredientRecipeResponse>().ReverseMap();

            CreateMap<Recipe, GetRecipeDetailsResponse>().ForMember(x=>x.RecipeId, y=>y.MapFrom(z=>z.Id)).ReverseMap();
            //sta mapiramo, nacin na koji mapiramo 

            CreateMap<RecipeCategory, UpdateCategoryRequest>().ReverseMap();

            CreateMap<RecipeCategory, AddCategoryRequest>().ReverseMap();

            CreateMap<Ingredient, GetIngredientsResponse>().ReverseMap();

            CreateMap<Recipe, UpdateRecipeRequest>().ReverseMap();

            CreateMap<Ingredient, UpdateIngredientRequest>().ReverseMap();

            CreateMap<Ingredient, AddIngredientRequest>().ReverseMap();

            CreateMap<IngredientRecipe, UpdateRecipeDetailsRequest>().ReverseMap();
            CreateMap<Recipe, GetRecipesResponse>().ReverseMap();

        }
    }
}
