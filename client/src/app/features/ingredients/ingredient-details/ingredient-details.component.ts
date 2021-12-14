import { Component, OnInit } from '@angular/core';
import { IngredientSearch } from 'app/core/dtos/IngredientSearch';
import { UnitMeasure } from 'app/core/enums/UnitMeasure';
import { PaginatedResult, Pagination } from 'app/core/helpers/Pagination';
import { GetIngredientsResponse } from 'app/core/responses/GetIngredientsResponse';
import { SharedService } from 'app/core/shared.service';
import { PaginationComponent } from 'ngx-bootstrap/pagination';
import { reduce } from 'rxjs/operators';

@Component({
  selector: 'app-ingredient-details',
  templateUrl: './ingredient-details.component.html',
  styleUrls: ['./ingredient-details.component.css']
})
export class IngredientDetailsComponent implements OnInit {

  Ingredients: GetIngredientsResponse[] = [];
  searchTerm: IngredientSearch = new IngredientSearch('', null, null);
  pagination: Pagination; 
  pageNumber=1; 
  pageSize=5; 
  orderBy='';
  number=5;


  constructor(public service: SharedService) {
  }
  
  ngOnInit(): void {

      this.loadIngredients(this.number,this.pageNumber, this.pageSize,this.searchTerm,this.orderBy);
  }
  
  loadIngredients(number:number,pageNumber:number, pageSize:number, searchTerm: IngredientSearch,orderBy:string) {
    this.service.gettAllIngredients(number,pageNumber, pageSize=number,searchTerm,orderBy).subscribe(
      response => {
        this.Ingredients = response.result;
        this.pagination= response.pagination; 
      }
      )
  }

  pageChanged(event:any)
  {
    this.pageNumber= event.page;
    this.loadIngredients(this.number,this.pageNumber, this.pageSize, this.searchTerm,this.orderBy); 
  }

  deleteIngredient(item) {
    this.service.deleteIngredient(item).subscribe(data => {
      this.loadIngredients(this.number,this.pageNumber, this.pageSize,this.searchTerm,this.orderBy);
    })
    location.reload();
  }
  
  Search() {
    this.loadIngredients(this.number,this.pageNumber, this.pageSize,this.searchTerm,this.orderBy);
  }
}
