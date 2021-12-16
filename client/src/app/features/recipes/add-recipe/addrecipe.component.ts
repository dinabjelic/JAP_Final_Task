import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoryService } from 'app/core/services/category.service';
import { IngredientService } from 'app/core/services/ingredient.service';
import { RecipeService } from 'app/core/services/recipe.service';
import { ToastrService } from 'ngx-toastr';
import { AddRecipes } from '../../../core/models/AddRecipes';
import { Ingredients } from '../../../core/models/Ingredients';

@Component({
  selector: 'app-addrecipe',
  templateUrl: './addrecipe.component.html',
  styleUrls: ['./addrecipe.component.css']
})
export class AddrecipeComponent implements OnInit {

  addRecipeForm: FormGroup = new FormGroup({});

  CategoryRecipesList: AddRecipes[] = [];
  Ingredients: Ingredients[] = [];
  IngredientsForm: Ingredients[]=[];

  public ingredientForm = this.formBuilder.group({
    quantity: ['', Validators.required],
    measure: ['', Validators.required],
    id : ['', Validators.required]
  })

  constructor(private formBuilder: FormBuilder, private service: RecipeService, private ingredientService: IngredientService,
    private toastr:ToastrService,public route:Router, private categoryService: CategoryService) { }
    
  ngOnInit(): void {

    this.addRecipeForm = this.formBuilder.group({
      categoryId: new FormControl('',Validators.required),
      name: new FormControl('',Validators.required),
      userID: new FormControl('',Validators.required),
      price: new FormControl('',Validators.required),
      description: new FormControl('',Validators.required),
      ingredientsList: this.Ingredients
    })

    this.loadIngredients();
    this.loadCategories();
  }

  onSubmit() {
    var model = new Ingredients(this.ingredientForm.value.id, this.ingredientForm.value.ingredientName, this.ingredientForm.value.quantity,
      this.ingredientForm.value.measure)
    this.Ingredients.push(model);
    console.log(this.Ingredients);
    this.ingredientForm.reset();

  }

  createRecipe() {
    this.addRecipeForm.value.ingredientsList = this.Ingredients;
    console.log(this.addRecipeForm.value);
    console.log("recipe added");
    this.service.addRecipe(this.addRecipeForm.value).subscribe(data => {
      this.toastr.success("Recipe succesfully created");
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to create recipe");
      console.log(this.addRecipeForm.value);
    }
    this.addRecipeForm.reset();
    setTimeout(() => {
      this.route.navigate(['/categories']);
    }, 2000);
  }

   loadIngredients() {
    this.ingredientService.getIngredients().subscribe
      (response => {
        this.IngredientsForm = response;
      })
  }
  loadCategories() {
    this.categoryService.getRecipesCategories().subscribe
      (response => {
        this.CategoryRecipesList = response;
      })
  }
}
