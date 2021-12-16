import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddrecipeComponent } from './features/recipes/add-recipe/addrecipe.component';
import { AddCategoryComponent } from './features/categories/add-category/add-category.component';
import { UpdateCategoryComponent } from './features/categories/update-category/update-category.component';
import { RecipesComponent } from './features/categories/category-table/recipes.component';
import { LoginformComponent } from './features/login-form/loginform.component';
import { RecipeDetailsComponent } from './features/recipes/recipe-details/recipe-details.component';
import { RecipesForCategoryComponent } from './features/recipes/recipes-for-category/recipes-for-category.component';
import { NavComponent } from './shared/nav/nav.component';
import { UpdateRecipeComponent } from './features/recipes/update-recipe/update-recipe.component';
import { IngredientDetailsComponent } from './features/ingredients/ingredient-details/ingredient-details.component';
import { AddIngredientComponent } from './features/ingredients/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './features/ingredients/update-ingredient/update-ingredient.component';
import { UpdateRecipeDetailsComponent } from './features/recipes/update-recipe-details/update-recipe-details.component';
import { AuthGuardGuard } from './core/guards/auth-guard';


const routes: Routes = [

{path:'categories',component:RecipesComponent,},
{path:'categories/:id', component:RecipesForCategoryComponent},
{path:'categories/:id/:recipeid', component:RecipeDetailsComponent},
{path:'auth',component:LoginformComponent},
{
    path: '',
    runGuardsAndResolvers:'always',
    canActivate: [AuthGuardGuard],
    children:[
      
      {path:'addnewrecipe', component:AddrecipeComponent},
      {path:'addcategory', component:AddCategoryComponent},
      {path:'updatecategory/:id',component:UpdateCategoryComponent},
      {path:'updaterecipe/:id', component:UpdateRecipeComponent},
      {path:'ingredients', component:IngredientDetailsComponent},
      {path:'ingredients/addingredient',component:AddIngredientComponent}, 
      {path:'ingredients/:id', component:UpdateIngredientComponent}, 
      {path:'categories/:ingredientsId/updaterecipedetails', component:UpdateRecipeDetailsComponent},
    ]
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }



