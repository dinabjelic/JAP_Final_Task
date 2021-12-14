import { UnitMeasure } from "../enums/UnitMeasure";

export class IngredientSearch{

    constructor(

        public name:string, 
        public quantity:number,
        public measure: UnitMeasure
    ){}
}