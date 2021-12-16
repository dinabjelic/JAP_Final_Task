import { Component, OnInit } from '@angular/core';
import { RecipesCategory } from 'app/core/models/RecipeCategory';
import { Pagination } from '../../../core/helpers/Pagination';
import { ToastrService } from 'ngx-toastr';
import { NgxBootstrapConfirmService } from 'ngx-bootstrap-confirm';
import { CategoryService } from 'app/core/services/category.service';

@Component({
  selector: 'app-category-recipes',
  templateUrl: './category-recipes.component.html',
  styleUrls: ['./category-recipes.component.css']
})
export class CategoryRecipesComponent implements OnInit {

  CategoryRecipesList: RecipesCategory[];
  pagination: Pagination;
  pageNumber = 1;
  pageSize = 10;
  constructor(public service: CategoryService, public toastr: ToastrService, private ngxBootstrapConfirmService: NgxBootstrapConfirmService) { }

  ngOnInit(): void {
    this.loadCategories();
  }


  loadCategories() {
    this.service.getCategories(this.pageNumber, this.pageSize).subscribe(response => {
      this.CategoryRecipesList = response.result;
      this.pagination = response.pagination;
    });
  }

  pageChanged(event: any) {
    this.pageNumber = event.page;
    this.loadCategories();
  }

  deleteCategory(item) {
    let options = {
      title: 'Sure you want to delete this category?',
      confirmLabel: 'Yes',
      declineLabel: 'Cancel'
    }
    this.ngxBootstrapConfirmService.confirm(options).then((res: boolean) => {
      if (res) {
        this.service.deleteCategory(item).subscribe(data => {
          this.loadCategories();
        })
        setTimeout(() => {
          location.reload();
        }, 1000);
      }
      this.toastr.success("Category succesfully deleted");
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to delete category");
    }
  }
}
