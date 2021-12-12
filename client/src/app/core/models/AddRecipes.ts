
export class AddRecipes{
    
    constructor(
        public id: number, 
        public name: string,
        public userId: number, 
        public price: number, 
        public description: string, 
        public categoryName: string, 
        public categoryId:number,
        public ingredientName: string, 
        public ingredientsList:[]
    ){}
}