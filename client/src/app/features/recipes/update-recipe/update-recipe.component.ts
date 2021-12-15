import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-recipe',
  templateUrl: './update-recipe.component.html',
  styleUrls: ['./update-recipe.component.css']
})
export class UpdateRecipeComponent implements OnInit {

  updateRecipeForm: FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder, private service: SharedService, private router: ActivatedRoute,
    private toastr:ToastrService,public route:Router) { 
    this.updateRecipeForm = this.formBuilder.group
    ({
       id: new FormControl(''),
       name: new FormControl(''),
       price: new FormControl(''),
       description: new FormControl('')
    })
  }

  ngOnInit(): void {

    this.service.getCurrentRecipeData(this.router.snapshot.params.id).subscribe((data)=>{
      this.updateRecipeForm = this.formBuilder.group
      ({
         id: new FormControl(this.router.snapshot.params.id),
         name: new FormControl(data[0].name),
         price: new FormControl(data[0].price),
         description: new FormControl(data[0].description)
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
