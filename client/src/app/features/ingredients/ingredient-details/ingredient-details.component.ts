import { Component, OnInit } from '@angular/core';
import { GetIngredientsResponse } from 'app/core/responses/GetIngredientsResponse';
import { SharedService } from 'app/core/shared.service';

@Component({
  selector: 'app-ingredient-details',
  templateUrl: './ingredient-details.component.html',
  styleUrls: ['./ingredient-details.component.css']
})
export class IngredientDetailsComponent implements OnInit {

  Ingredients:GetIngredientsResponse[]=[];
  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.loadIngredients();
  }

  loadIngredients(){
    this.service.gettAllIngredients().subscribe(
      response=>{
        this.Ingredients=response;
      }
    )
  }

  deleteIngredient(item){
    this.service.deleteIngredient(item).subscribe(data=>{
      this.loadIngredients();
    })
    location.reload();
  }
}
