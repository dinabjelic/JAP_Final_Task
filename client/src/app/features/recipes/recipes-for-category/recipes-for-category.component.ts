import { SelectorMatcher } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from 'app/core/services/recipe.service';
import { NgxBootstrapConfirmService } from 'ngx-bootstrap-confirm';
import { ToastrService } from 'ngx-toastr';
import { RecipesCategories } from '../../../core/models/RecipesCategories';

@Component({
  selector: 'app-recipes-for-category',
  templateUrl: './recipes-for-category.component.html',
  styleUrls: ['./recipes-for-category.component.css']
})
export class RecipesForCategoryComponent implements OnInit {

  CategoryRecipesList: RecipesCategories[]=[];
  categoryrecipes : RecipesCategories;
  recipeName: any;
  searchTerm:string="";
  recipeCategoryId:number;
 
  constructor(public service:RecipeService, private route:ActivatedRoute,private ngxBootstrapConfirmService: NgxBootstrapConfirmService,
    private toastr:ToastrService) { }


  ngOnInit(): void {
  
    this.loadRecipeCategory(this.route.snapshot.params.id,this.searchTerm);
  }

    loadRecipeCategory(id:number,searchTerm:string){
      this.service.getAllCategoryRecipes(this.route.snapshot.params.id,this.searchTerm).subscribe(
        response=>{
          this.CategoryRecipesList= response; 
        });
    }
    
    deleteRecipe(item){
      let options ={
        title: 'Sure you want to delete this ingredient?',
        confirmLabel: 'Yes',
        declineLabel: 'Cancel'
      }
      this.ngxBootstrapConfirmService.confirm(options).then((res: boolean) => {
        if (res) {
          this.service.deleteRecipe(item).subscribe(data=>{
            this.loadRecipeCategory(this.route.snapshot.params.id,this.searchTerm);
          })
          setTimeout(() => {
            location.reload();
          }, 1000);
        } 
        this.toastr.success("Recipe succesfully deleted");
      }), err => {
        this.toastr.error(err.error);
        console.log("Unable to delete recipe");
      }
    }

    Search()
    {
        this.loadRecipeCategory(this.route.snapshot.params.id,this.searchTerm);
    }
}
    
