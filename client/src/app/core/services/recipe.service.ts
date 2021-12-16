import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { environment } from "environments/environment";
import { RecipesCategories } from "../models/RecipesCategories";
import { UpdateRecipeDetailsRequest } from "../requests/UpdateRecipeDetailsRequest";
import { UpdateRecipeRequest } from "../requests/UpdateRecipeRequest";

@Injectable({
    providedIn: 'root'
})
export class RecipeService {
    public isAuthenticated = false;

    constructor(private http: HttpClient, public router: Router) { }


    getCurrentRecipeData(recipeId: number) {
        return this.http.get<UpdateRecipeRequest>(`${environment.apiUrl}` + "Recipes/" + recipeId);
    }

    getRecipeDetails(recipeid) {
        return this.http.get<RecipesCategories>(`${environment.apiUrl}` + "Recipes/recipe-details/" + recipeid);
    }

    addRecipe(model: any) {
        return this.http.post(`${environment.apiUrl}` + "Recipes", model);
    }

    updateRecipe(model: UpdateRecipeRequest) {
        return this.http.put<UpdateRecipeRequest>(`${environment.apiUrl}` + "Recipes", model);
    }

    updateRecipeDetails(model: UpdateRecipeDetailsRequest) {
        return this.http.put<UpdateRecipeDetailsRequest>(`${environment.apiUrl}` + "Recipes/update-recipe-details", model);
    }

    deleteRecipe(recipeId: number) {
        return this.http.delete(`${environment.apiUrl}` + "Recipes/" + recipeId);
    }

    getAllCategoryRecipes(recipeCategoryId: number, searchTerm: string) {
        let params = new HttpParams()
            .set("recipeCategoryId", recipeCategoryId)
            .set("searchTerm", searchTerm);

        return this.http.get<RecipesCategories[]>(`${environment.apiUrl}` + "Recipes/get-by-category/" + recipeCategoryId, {
            params: params
        });
    }
}
