export class User {
    public id: number;
    public phoneOrEmail: string;
     public password: string;
     public confirmPassword: string;
     public typeUser: string;
     public tegs: string;
  
    constructor(id, name, price) {
        debugger
        this.id = id;
        this.name = name;
        this.price = price;
    }
}