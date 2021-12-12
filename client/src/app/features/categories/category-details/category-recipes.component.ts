import { Component, OnInit } from '@angular/core';
import { RecipesCategory } from 'app/core/models/RecipeCategory';
import { Pagination } from '../../../core/helpers/Pagination';
import { RecipesCategories } from '../../../core/models/RecipesCategories';
import { SharedService } from '../../../core/shared.service';
import { User } from '../../../core/models/User';

@Component({
  selector: 'app-category-recipes',
  templateUrl: './category-recipes.component.html',
  styleUrls: ['./category-recipes.component.css']
})
export class CategoryRecipesComponent implements OnInit {
  
    // CategoryRecipesList: any=[]; 
  // CategoryRecipesList: RecipesCategories[]=[]; 


  CategoryRecipesList: RecipesCategory[];
  pagination: Pagination; 
  pageNumber=1; 
  pageSize=10; 
  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.loadCategories();
    // this.setCurrentUser();

  }

  // setCurrentUser(){
  //   const user: User= JSON.parse(localStorage.getItem('user')); 
  //   this.service.setCurrentUser(user); 
    
  // }

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
    })
    location.reload();
  }
}


//subscribe metoda ceka dok response nije primljen iz apija i onda samo assigna vrijednost koju je primio
//na varijablu koju mi definisemo