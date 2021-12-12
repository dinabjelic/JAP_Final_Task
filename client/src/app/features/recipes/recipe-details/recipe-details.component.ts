import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipesCategories } from '../../../core/models/RecipesCategories';
import { SharedService } from '../../../core/shared.service';

@Component({
  selector: 'app-recipe-details',
  templateUrl: './recipe-details.component.html',
  styleUrls: ['./recipe-details.component.css']
})
export class RecipeDetailsComponent implements OnInit {

  CategoryRecipesList: RecipesCategories; 
  ingredientName:any;
  names: RecipesCategories;
  sum:number;

 constructor(private service:SharedService, private route:ActivatedRoute) { }

  ngOnInit(): void {

    this.loadRecipeDetails();

  }
  
  loadRecipeDetails(){
    this.service.getRecipeDetails(this.route.snapshot.params.recipeid).subscribe(
      data=>{this.CategoryRecipesList=data;});
    }


    // Search()
    // {
    //   if(this.ingredientName.length < 2)
    //   {
    //     this.loadRecipeDetails();
    //   }
    //   else
    //   {
    //     this.CategoryRecipesList= this.CategoryRecipesList.filter(res=>{
    //        return res.ingredientName.toLocaleLowerCase().match(this.ingredientName.toLocaleLowerCase());})
    //   }
    // }
  
}
