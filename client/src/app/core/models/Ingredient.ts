import { UnitMeasure } from "../enums/UnitMeasure";

export class Ingredient{

    constructor(
        public id: number, 
        public measure: UnitMeasure, 
        public name: string, 
        public price: number, 
        public quantity:number
    ){}
}