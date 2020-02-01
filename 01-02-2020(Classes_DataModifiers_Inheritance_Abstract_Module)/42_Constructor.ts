class Idea{
    name: string;
    age: number;

    constructor (Name: string, Age: number){
        this.name = Name;
        this.age = Age;
    }    
}
let obj = new Idea("Steve", 20);
console.log("Name: " + obj.name);
console.log("Age: " + obj.age);

