class Employee{
    empName: string;
    empCode: number;

    constructor(code: number, name: string){
        this.empName = name;
        this.empCode = code;
    }
    display = () => console.log(this.empCode + " " + this.empName);
    
}
let emp = new Employee(1, "ram");
emp.display();