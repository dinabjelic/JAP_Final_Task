import { IngredientRecipe } from "./IngredientRecipe";

export class RecipesCategories{

    constructor(
       
        public ingredientName:string, 
        public recipeId:number, 
        public name: string, 
        public description: string,
        public ingredientRecipes: IngredientRecipe[] 
){}
}