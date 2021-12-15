import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-ingredient',
  templateUrl: './update-ingredient.component.html',
  styleUrls: ['./update-ingredient.component.css']
})
export class UpdateIngredientComponent implements OnInit {

  updateIngredientForm: FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder, private service: SharedService, private router: ActivatedRoute,
    private toastr:ToastrService,public route:Router) {
    this.updateIngredientForm = this.formBuilder.group({
       id: new FormControl(''),
       name: new FormControl(''),
       price: new FormControl(''),
       quantity: new FormControl(''), 
       measure: new FormControl('')
    })
    console.log(this.router.snapshot.params.id);
   }

  ngOnInit(): void {
    this.service.getCurrentIngredientData(this.router.snapshot.params.id).subscribe((data)=>{
      this.updateIngredientForm = this.formBuilder.group({
        id: new FormControl(this.router.snapshot.params.id),
        name: new FormControl(data[0].name),
        price: new FormControl(data[0].price),
        quantity: new FormControl(data[0].quantity), 
        measure: new FormControl(data[0].measure)
     })
    })
  }

  updateIngredient(){
    this.service.updateIngredient(this.updateIngredientForm.value).subscribe(data => {
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to update ingredient ");
    }
    this.updateIngredientForm.reset();
    setTimeout(() => {
      this.route.navigate(['/ingredients']);
    }, 2000);
    this.toastr.success("Ingredient succesfully updated");
  }
}
