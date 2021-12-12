import { UnitMeasure } from "../enums/UnitMeasure";

export class Ingredients{
    
    constructor(
        public id:number,
        public name:string,
        public quantity:number,
        public measure: UnitMeasure
    ){}
}