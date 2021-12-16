import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { environment } from "environments/environment";
import { map } from "rxjs/operators";
import { IngredientSearch } from "../dtos/IngredientSearch";
import { PaginatedResult } from "../helpers/Pagination";
import { Ingredients } from "../models/Ingredients";
import { UpdateIngredientRequest } from "../requests/UpdateIngredientRequest";
import { GetIngredientsResponse } from "../responses/GetIngredientsResponse";

@Injectable({
    providedIn: 'root'
})
export class IngredientService {

    paginatedResult2: PaginatedResult<GetIngredientsResponse[]> = new PaginatedResult<GetIngredientsResponse[]>();

    constructor(private http: HttpClient, public router: Router) { }

    gettAllIngredients(number?: number, page?: number, itemsPerPage?: number, searchTerm?: IngredientSearch, orderBy?: string) {
        let params = new HttpParams()
            .set("name", searchTerm?.name ?? '')
            .set("measure", searchTerm?.measure ?? '')
            .set("quantity", searchTerm?.quantity ?? '')
            .set("number", number ?? '')
            .set("orderBy", orderBy ?? '');

        if (page !== null && itemsPerPage !== null) {
            params = params.append('pageNumber', page.toString());
            params = params.append('pageSize', itemsPerPage.toString());
        }

        return this.http.get<GetIngredientsResponse[]>(`${environment.apiUrl}` + "Ingredients/all-ingredients", {
            observe: 'response',
            params: params
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

    getCurrentIngredientData(ingredientId: number) {
        return this.http.get<UpdateIngredientRequest>(`${environment.apiUrl}` + "Ingredients/" + ingredientId);
    }

    getIngredients() {
        return this.http.get<Ingredients[]>(`${environment.apiUrl}` + "Ingredients");
    }


    addIngredient(model: any) {
        return this.http.post(`${environment.apiUrl}` + "Ingredients", model);
    }

    updateIngredient(model: UpdateIngredientRequest) {
        return this.http.put<UpdateIngredientRequest>(`${environment.apiUrl}` + "Ingredients", model);
    }

    deleteIngredient(ingredientId: number) {
        return this.http.delete(`${environment.apiUrl}` + "Ingredients/" + ingredientId)
    }
}