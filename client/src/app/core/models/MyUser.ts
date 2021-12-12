import { IdentityUser } from "./IdentityUser";

export class MyUser{
    constructor(
        public id:number,
        public firstName:string,
        public lastName:string,
        public user:IdentityUser){}
}