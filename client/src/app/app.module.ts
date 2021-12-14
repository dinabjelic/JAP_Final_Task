import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryRecipesComponent } from './features/categories/category-details/category-recipes.component';
import { SharedService } from './core/shared.service';

import{HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RecipesComponent } from './features/categories/category-table/recipes.component';
import { RecipesForCategoryComponent } from './features/recipes/recipes-for-category/recipes-for-category.component';
import { ShowcategoryrecipesComponent } from './features/recipes/show-category-recipes/showcategoryrecipes.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { RecipeDetailsComponent } from './features/recipes/recipe-details/recipe-details.component';
import { ShowrecipedetailsComponent } from './features/recipes/show-recipe-details/showrecipedetails.component';
import { AddrecipeComponent } from './features/recipes/add-recipe/addrecipe.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ShowformsComponent } from './features/show-forms/showforms.component';
import {MatInputModule} from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {PaginationModule} from 'ngx-bootstrap/pagination';
import { NgxPaginationModule } from 'ngx-pagination';
import { LoginformComponent } from './features/login-form/loginform.component';
import { NavComponent } from './shared/nav/nav.component';
import { ShowloginComponent } from './features/show-login/showlogin.component';
import { AddCategoryComponent } from './features/categories/add-category/add-category.component';
import { UpdateCategoryComponent } from './features/categories/update-category/update-category.component';
import { UpdateRecipeComponent } from './features/recipes/update-recipe/update-recipe.component';
import { IngredientDetailsComponent } from './features/ingredients/ingredient-details/ingredient-details.component';
import { AddIngredientComponent } from './features/ingredients/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './features/ingredients/update-ingredient/update-ingredient.component';
import { UpdateRecipeDetailsComponent } from './features/recipes/update-recipe-details/update-recipe-details.component';
import {ButtonsModule} from 'ngx-bootstrap/buttons';





@NgModule({
  declarations: [
    AppComponent,
    CategoryRecipesComponent,
    RecipesComponent,
    RecipesForCategoryComponent,
    ShowcategoryrecipesComponent,
    RecipeDetailsComponent,
    ShowrecipedetailsComponent,
    AddrecipeComponent,
    ShowformsComponent,
    LoginformComponent,
    NavComponent,
    ShowloginComponent,
    AddCategoryComponent,
    UpdateCategoryComponent,
    UpdateRecipeComponent,
    IngredientDetailsComponent,
    AddIngredientComponent,
    UpdateIngredientComponent,
    UpdateRecipeDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule, 
    FormsModule, 
    ReactiveFormsModule, 
    Ng2SearchPipeModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatCardModule,
    BrowserAnimationsModule, 
    PaginationModule.forRoot(),
    NgxPaginationModule,
    ButtonsModule.forRoot()
    // MatSnackBar
    
  ],
  providers: [SharedService],
  bootstrap: [AppComponent],
  
  
})
export class AppModule { }
