import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SharedService } from 'app/core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {

  addIngredientForm:FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder,private service: SharedService,private toastr:ToastrService,public route:Router) { }

  ngOnInit(): void {
    this.addIngredientForm = this.formBuilder.group({
      'name': new FormControl('',[Validators.required]),
      'price': new FormControl('',[Validators.required]),
      'quantity': new FormControl('',[Validators.required]), 
      'measure': new FormControl('',[Validators.required])
    })
  }

  addIngredient(){
    this.service.addIngredient(this.addIngredientForm.value).subscribe(data=>{
    }),err=>{
      this.toastr.error(err.error);
    }
    setTimeout(() => {
      this.route.navigate(['/ingredients']);
    }, 2000);
    this.addIngredientForm.reset();
    this.toastr.success("Ingredient succesfully added");
  }

}
