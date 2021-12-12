import { UnitMeasure } from "../enums/UnitMeasure";

export class UpdateIngredientRequest{

    constructor(

        public id:number,
        public name:string, 
        public price:number, 
        public quantity:number, 
        public measure: UnitMeasure
    ){}
}