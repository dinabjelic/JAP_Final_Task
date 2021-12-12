import { UnitMeasure } from "../enums/UnitMeasure";

export class GetIngredientsResponse{
    
    constructor(

        public id:string,
        public name:string, 
        public price:number, 
        public quantity:number, 
        public measure: UnitMeasure
    ){}
}