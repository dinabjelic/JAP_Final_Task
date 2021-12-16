import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { environment } from "environments/environment";
import { map } from "rxjs/operators";
import { PaginatedResult } from "../helpers/Pagination";
import { AddRecipes } from "../models/AddRecipes";
import { RecipesCategory } from "../models/RecipeCategory";
import { UpdateCategoryRequest } from "../requests/UpdateCategoryRequest";

@Injectable({
    providedIn: 'root'
})
export class CategoryService {

    paginatedResult: PaginatedResult<RecipesCategory[]> = new PaginatedResult<RecipesCategory[]>();


    constructor(private http: HttpClient, public router: Router) {
     }

    getCategories(page?: number, itemsPerPage?: number) {
        let params = new HttpParams();

        if (page !== null && itemsPerPage !== null) {
            params = params.append('pageNumber', page.toString());
            params = params.append('pageSize', itemsPerPage.toString());
        }

        return this.http.get<RecipesCategory[]>(`${environment.apiUrl}` + "Categories", { observe: 'response', params }).pipe(
            map(response => {
                this.paginatedResult.result = response.body;
                if (response.headers.get('Pagination') !== null) {
                    this.paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
                }
                return this.paginatedResult;
            })
        )
    }

    getCurrentCategoryData(categoryId: number) {
        return this.http.get<UpdateCategoryRequest>(`${environment.apiUrl}` + "Categories/" + categoryId);
    }

    addCategory(model: any) {
        return this.http.post(`${environment.apiUrl}` + "Categories", model);
    }

    updateCategory(model: UpdateCategoryRequest) {
        return this.http.put<UpdateCategoryRequest>(`${environment.apiUrl}` + "Categories", model);
    }

    deleteCategory(categoryId: number) {
        return this.http.delete(`${environment.apiUrl}` + "Categories/" + categoryId);
    }

    getRecipesCategories() {
        return this.http.get<AddRecipes[]>(`${environment.apiUrl}` + "Categories/categories-list");
    }

}