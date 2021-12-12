import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SharedService } from 'app/core/shared.service';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {

  addIngredientForm:FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder,private service: SharedService) { }

  ngOnInit(): void {
    this.addIngredientForm = this.formBuilder.group({
      'name': new FormControl(''),
      'price': new FormControl(''),
      'quantity': new FormControl(''), 
      'measure': new FormControl('')
    })
  }

  addIngredient(){
    this.service.addIngredient(this.addIngredientForm.value).subscribe(data=>{
    }),err=>{
      console.log("Unable to create ingredient ");
    }
    this.addIngredientForm.reset();
  }

}
