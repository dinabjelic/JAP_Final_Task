import { Ingredient } from "./Ingredient";
import { UnitMeasure } from "../enums/UnitMeasure";

export class IngredientRecipe{

    constructor(
        public measure:UnitMeasure, 
        public quantity: number, 
        public ingredientPrice: number, 
        public totalCost: number, 
        public ingredients: Ingredient

    ){}
}