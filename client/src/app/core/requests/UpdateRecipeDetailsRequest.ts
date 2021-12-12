import { UnitMeasure } from "../enums/UnitMeasure";

export class UpdateRecipeDetailsRequest{

    constructor(
        public recipesId: number, 
        public ingredientsId:number, 
        public quantity: number, 
        public measure:UnitMeasure
    ){}
}