import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeService } from 'app/core/services/recipe.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-recipe',
  templateUrl: './update-recipe.component.html',
  styleUrls: ['./update-recipe.component.css']
})
export class UpdateRecipeComponent implements OnInit {

  updateRecipeForm: FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder, private service: RecipeService, private router: ActivatedRoute,
    private toastr:ToastrService,public route:Router) { 
    this.updateRecipeForm = this.formBuilder.group
    ({
       id: new FormControl(''),
       name: new FormControl(''),
       price: new FormControl(''),
       description: new FormControl('')
    })
    console.log(this.router.snapshot.params.id);
  }
  
  ngOnInit(): void {
    
    this.service.getCurrentRecipeData(this.router.snapshot.params.id).subscribe((data)=>{
      this.updateRecipeForm = new FormGroup
      ({
        id: new FormControl(this.router.snapshot.params.id),
        name: new FormControl(data['name']),
        price: new FormControl(data['price']),
        description: new FormControl(data['description']),
      })
    })
  }
  
  updateRecipe() {
    this.service.updateRecipe(this.updateRecipeForm.value).subscribe(data => {
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to update recipe");
    }
    this.updateRecipeForm.reset();
    setTimeout(() => {
      this.route.navigate(['/categories']);
    }, 2000);
    this.toastr.success("Recipe succesfully updated");
  }
}
