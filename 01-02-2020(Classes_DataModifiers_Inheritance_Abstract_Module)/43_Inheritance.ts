class Person{
    empName: string;
    constructor(name: string){
        this.empName = name;
    }
}
class Employee extends Person{
    empCode: number;
    constructor(code: number, name: string){
        super(name);
        this.empCode = code;
    }
    displayName() : void{
        console.log("Name: " + this.empName + " With employeeId: " + this.empCode);        
    }
}
let empObj = new Employee(100, "Ron  Wesely");
empObj.displayName();