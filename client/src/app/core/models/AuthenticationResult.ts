import { MyUser } from "./MyUser";

export class AuthenticationResult{
    constructor(
        public token:string,
        public expiration:Date,
        public user:string,
        public myUser:MyUser
    ){}
}