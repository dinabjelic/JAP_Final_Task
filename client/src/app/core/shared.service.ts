import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, ReplaySubject } from 'rxjs'; //sluzi za asinhrone requests i responses  
import { RecipesCategories } from './models/RecipesCategories';
import { AddRecipes } from './models/AddRecipes';
import { PaginatedResult } from './helpers/Pagination';
import { map, catchError } from 'rxjs/operators';
import { User } from './models/User';
import { RecipesCategory } from './models/RecipeCategory';
import { Ingredients } from './models/Ingredients';
import { AuthenticationResult } from 'app/core/models/AuthenticationResult';
import { Router } from '@angular/router';
import { UpdateCategoryRequest } from './requests/UpdateCategoryRequest';
import { UpdateRecipeRequest } from './requests/UpdateRecipeRequest';
import { GetIngredientsResponse } from './responses/GetIngredientsResponse';
import { UpdateIngredientRequest } from './requests/UpdateIngredientRequest';
import { UpdateRecipeDetailsRequest } from './requests/UpdateRecipeDetailsRequest';
import { IngredientSearch } from './dtos/IngredientSearch';


@Injectable({
  providedIn: 'root'
})
export class SharedService {

  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  public isAuthenticated = false;
  readonly ApiUrl = "https://localhost:5001/api/";
  paginatedResult: PaginatedResult<RecipesCategory[]> = new PaginatedResult<RecipesCategory[]>();
  paginatedResult2: PaginatedResult<GetIngredientsResponse[]>= new PaginatedResult<GetIngredientsResponse[]>();


  constructor(private http: HttpClient, public router: Router) {
    this.isAuthenticated = localStorage.getItem('token') != null
      && localStorage.getItem('token') != undefined && localStorage.getItem('token') != "";
  }

  getCategories(page?: number, itemsPerPage?: number) {
    let params = new HttpParams();

    if (page !== null && itemsPerPage !== null) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }

    return this.http.get<RecipesCategory[]>(this.ApiUrl + "Categories", { observe: 'response', params }).pipe(
      map(response => {
        this.paginatedResult.result = response.body;
        if (response.headers.get('Pagination') !== null) {
          this.paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        return this.paginatedResult;
      })
    )
  }

  gettAllIngredients(number?:number,page?: number, itemsPerPage?: number,searchTerm?:IngredientSearch,orderBy?:string){
    let params = new HttpParams()
    .set("name",searchTerm?.name??'')
    .set("measure", searchTerm?.measure??'')
    .set("quantity", searchTerm?.quantity??'')
    .set("number",number??'')
    .set("orderBy",orderBy??'');

    if (page !== null && itemsPerPage !== null) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }

    return this.http.get<GetIngredientsResponse[]>(this.ApiUrl + "Ingredients/all-ingredients",{
      observe: 'response',
      params:params
    }).pipe(
      map(response => {
        this.paginatedResult2.result = response.body;
        if (response.headers.get('Pagination') !== null) {
          this.paginatedResult2.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        return this.paginatedResult2;
      })
    );
  }

  getCurrentCategoryData(categoryId:number)
  {
    return this.http.get<UpdateCategoryRequest>(this.ApiUrl + "Categories/"+ categoryId);
  }

  getCurrentIngredientData(ingredientId:number)
  {
    return this.http.get<UpdateIngredientRequest>(this.ApiUrl+"Ingredients/"+ingredientId);
  }

  getCurrentRecipeData(recipeId:number)
  {
    return this.http.get<UpdateRecipeRequest>(this.ApiUrl+"Recipes/current-data/"+ recipeId);
  }

  getAllCategoryRecipes(recipeCategoryId: number, searchTerm: string) {
    let params = new HttpParams()
      .set("recipeCategoryId", recipeCategoryId)
      .set("searchTerm", searchTerm);

    return this.http.get<RecipesCategories[]>(this.ApiUrl + "Recipes/" + recipeCategoryId, {
      params: params
    });
  }

  addCategory(model:any)
  {
    return this.http.post(this.ApiUrl+ "Categories",model);
  }
  updateCategory(model:UpdateCategoryRequest)
  {
    return this.http.put<UpdateCategoryRequest>(this.ApiUrl+"Categories",model);
  }
  deleteCategory(categoryId:number)
 {
    return this.http.delete(this.ApiUrl+"Categories/"+ categoryId);
 } 

  getRecipeDetails(recipeid) {
    return this.http.get<RecipesCategories>(this.ApiUrl + "Recipes/recipe-details/" + recipeid);
  }

  addRecipe(model: any) {
    return this.http.post(this.ApiUrl + "Recipes", model);
  }
  
  updateRecipe(model:UpdateRecipeRequest)
  {
    return this.http.put<UpdateRecipeRequest>(this.ApiUrl+"Recipes",model);
  }
  updateRecipeDetails(model:UpdateRecipeDetailsRequest){
    return this.http.put<UpdateRecipeDetailsRequest>(this.ApiUrl+"Recipes/update-recipe-details",model);
  }
  deleteRecipe(recipeId:number)
  {
     return this.http.delete(this.ApiUrl+"Recipes/"+ recipeId);
  } 

  getIngredients() {
    return this.http.get<Ingredients[]>(this.ApiUrl + "Ingredients");
  }

 
  addIngredient(model:any)
  {
    return this.http.post(this.ApiUrl+"Ingredients",model);
  }

  updateIngredient(model:UpdateIngredientRequest)
  {
    return this.http.put<UpdateIngredientRequest>(this.ApiUrl+"Ingredients",model);
  }
  
  deleteIngredient(ingredientId:number)
  {
    return this.http.delete(this.ApiUrl+"Ingredients/"+ingredientId)
  }

  getRecipesCategories() {
    return this.http.get<AddRecipes[]>(this.ApiUrl + "Categories/categories-list");
  }

  login(model: any) {
    return this.http.post<AuthenticationResult>('https://localhost:5001/api/Authentication/Login', model);
  }

  logout() {
    localStorage.removeItem('token');
    this.router.navigate(['/auth']);
  }

}
