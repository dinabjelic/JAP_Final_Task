import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AddRecipes } from '../../../core/models/AddRecipes';
import { IngredientList } from '../../../core/models/IngredientList';
import { Ingredients } from '../../../core/models/Ingredients';
import { SharedService } from '../../../core/shared.service';

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
  
  constructor(private formBuilder: FormBuilder, private service: SharedService) { }
  ngOnInit(): void {

    this.addRecipeForm = this.formBuilder.group({
      'categoryId': new FormControl('',Validators.required),
      'name': new FormControl('',Validators.required),
      'userId': new FormControl('',Validators.required),
      'price': new FormControl('',Validators.required),
      'description': new FormControl('',Validators.required),
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
    }), err => {
      console.log("Unable to create recipe");
      console.log(this.addRecipeForm.value);
    }
  }

   loadIngredients() {
    this.service.getIngredients().subscribe
      (response => {
        this.IngredientsForm = response;
      })
  }
  loadCategories() {
    this.service.getRecipesCategories().subscribe
      (response => {
        this.CategoryRecipesList = response;
      })
  }
}
