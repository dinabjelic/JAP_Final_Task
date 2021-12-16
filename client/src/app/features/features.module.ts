import { NgModule } from '@angular/core';
import { AppRoutingModule } from 'app/app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RecipesComponent } from './categories/category-table/recipes.component';
import { RecipesForCategoryComponent } from './recipes/recipes-for-category/recipes-for-category.component';
import { ShowcategoryrecipesComponent } from './recipes/show-category-recipes/showcategoryrecipes.component';
import { RecipeDetailsComponent } from './recipes/recipe-details/recipe-details.component';
import { ShowrecipedetailsComponent } from './recipes/show-recipe-details/showrecipedetails.component';
import { AddrecipeComponent } from './recipes/add-recipe/addrecipe.component';
import { ShowformsComponent } from './recipes/show-forms/showforms.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {PaginationModule} from 'ngx-bootstrap/pagination';
import { NgxPaginationModule } from 'ngx-pagination';
import { AddCategoryComponent } from './categories/add-category/add-category.component';
import { UpdateCategoryComponent } from './categories/update-category/update-category.component';
import { UpdateRecipeComponent } from './recipes/update-recipe/update-recipe.component';
import { IngredientDetailsComponent } from './ingredients/ingredient-details/ingredient-details.component';
import { AddIngredientComponent } from './ingredients/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './ingredients/update-ingredient/update-ingredient.component';
import { UpdateRecipeDetailsComponent } from './recipes/update-recipe-details/update-recipe-details.component';
import { LoginformComponent } from './login-form/loginform.component';
import { CategoryRecipesComponent } from './categories/category-details/category-recipes.component';
import { AutheticationService } from 'app/core/services/authetication.service';
import { RecipeService } from 'app/core/services/recipe.service';
import { CategoryService } from 'app/core/services/category.service';
import { IngredientService } from 'app/core/services/ingredient.service';

@NgModule({
  declarations: [
    RecipesComponent,
    RecipesForCategoryComponent,
    ShowcategoryrecipesComponent,
    RecipeDetailsComponent,
    ShowrecipedetailsComponent,
    AddrecipeComponent,
    ShowformsComponent,
    AddCategoryComponent,
    UpdateCategoryComponent,
    UpdateRecipeComponent,
    IngredientDetailsComponent,
    AddIngredientComponent,
    UpdateIngredientComponent,
    UpdateRecipeDetailsComponent, 
    LoginformComponent,
    CategoryRecipesComponent
  ],
  imports: [
    FormsModule, 
    ReactiveFormsModule, 
    BrowserAnimationsModule, 
    NgxPaginationModule,
    PaginationModule.forRoot(),
    AppRoutingModule,
    BrowserModule
  ],
  providers: [
    AutheticationService,
    RecipeService,
    CategoryService,
    IngredientService
  ],
  
})
export class FeaturesModule { }