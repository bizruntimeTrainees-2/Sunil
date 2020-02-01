abstract class Per{
    name: string;
    constructor(Name: string){
        this.name=Name;
    }
    display(): void{
        console.log(this.name);
        
    }
    abstract find(string: any): Per
}
class Em extends Per{
    emCode: number;
    constructor(name: string, Code:number){
        super(name);
        this.emCode=Code;
    }
    find(name:string):Per{
        //Executes AJAX request to find an employeee fro  DB
        return new Em(name, 1);
    }
}
let em:Per = new Em("James", 100);
em.display();

let em2:Per = em.find("ramu");