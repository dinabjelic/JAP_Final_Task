import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IngredientSearch } from 'app/core/dtos/IngredientSearch';
import { PaginatedResult, Pagination } from 'app/core/helpers/Pagination';
import { GetIngredientsResponse } from 'app/core/responses/GetIngredientsResponse';
import { SharedService } from 'app/core/shared.service';
import { NgxBootstrapConfirmService } from 'ngx-bootstrap-confirm';
import { ToastrService } from 'ngx-toastr';


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


  constructor(public service: SharedService,private ngxBootstrapConfirmService: NgxBootstrapConfirmService,
    private toastr:ToastrService,public route:Router) {
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

    let options ={
      title: 'Sure you want to delete this ingredient?',
      confirmLabel: 'Yes',
      declineLabel: 'Cancel'
    }
    this.ngxBootstrapConfirmService.confirm(options).then((res: boolean) => {
      if (res) {
        this.service.deleteIngredient(item).subscribe(data => {
          this.loadIngredients(this.number,this.pageNumber, this.pageSize,this.searchTerm,this.orderBy);
        })
        setTimeout(() => {
          location.reload();
        }, 1000);
      } 
      this.toastr.success("Ingredient succesfully deleted");
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to delete ingredient");
    }
  }
  
  Search() {
    this.loadIngredients(this.number,this.pageNumber, this.pageSize,this.searchTerm,this.orderBy);
  }
}
