import { Component, OnInit } from '@angular/core';
import { RecipesCategory } from 'app/core/models/RecipeCategory';
import { Pagination } from '../../../core/helpers/Pagination';
import { SharedService } from '../../../core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-category-recipes',
  templateUrl: './category-recipes.component.html',
  styleUrls: ['./category-recipes.component.css']
})
export class CategoryRecipesComponent implements OnInit {
  
  CategoryRecipesList: RecipesCategory[];
  pagination: Pagination; 
  pageNumber=1; 
  pageSize=10; 
  constructor(private service:SharedService, public toastr:ToastrService) { }

  ngOnInit(): void {
    this.loadCategories();
  }


  loadCategories(){
    this.service.getCategories(this.pageNumber, this.pageSize).subscribe(response=>{
      this.CategoryRecipesList= response.result; 
      this.pagination= response.pagination; 
    });
  }

  pageChanged(event:any)
  {
    this.pageNumber= event.page;
    this.loadCategories(); 
  }

  deleteCategory(item){
    this.service.deleteCategory(item).subscribe(data=>{
      this.loadCategories();
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to delete category");
    }
    this.toastr.success("Category succesfully deleted");
    setTimeout(() => {
      location.reload();
    }, 2000);
  }
}
