import { SelectorMatcher } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipesCategories } from '../../../core/models/RecipesCategories';
import { SharedService } from '../../../core/shared.service';

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
 
  constructor(private service:SharedService, private route:ActivatedRoute) { }


  ngOnInit(): void {
  
    this.loadRecipesCategory();
  }


  loadRecipesCategory(){
    this.service.getAllCategoryRecipes(this.route.snapshot.params.id,this.searchTerm).subscribe(
      response=>{
        this.CategoryRecipesList= response; 
      });
    }

    
    deleteRecipe(item){
      this.service.deleteRecipe(item).subscribe(data=>{
        this.loadRecipesCategory();
      })
      location.reload();
    }

   
    Search()
    {
      if(this.searchTerm.length < 2)
      {
        this.loadRecipesCategory();
      }
      else
      {
        this.CategoryRecipesList= this.CategoryRecipesList.filter(res=>{
           return res.name.toLocaleLowerCase().match(this.searchTerm.toLocaleLowerCase());})
      }
    }
}
    
