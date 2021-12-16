import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from 'app/core/services/recipe.service';

@Component({
  selector: 'app-update-recipe-details',
  templateUrl: './update-recipe-details.component.html',
  styleUrls: ['./update-recipe-details.component.css']
})
export class UpdateRecipeDetailsComponent implements OnInit {

  updateRecipeDetailsForm: FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder, private service: RecipeService, private router: ActivatedRoute) { }

  ngOnInit(): void {
    this.updateRecipeDetailsForm = this.formBuilder.group
      ({
        'recipesId': this.router.snapshot.params.recipesId,
        'ingredientsId': this.router.snapshot.params.ingredientsId,
        'quantity': new FormControl(''),
        'measure': new FormControl(''),
      })
    console.log(this.router.snapshot.params.Id);
  }
  updateRecipeDetails() {
    this.service.updateRecipeDetails(this.updateRecipeDetailsForm.value).subscribe(data => {
    }), err => {
      console.log("Unable to update recipe");
    }
    this.updateRecipeDetailsForm.reset();
  }
}
