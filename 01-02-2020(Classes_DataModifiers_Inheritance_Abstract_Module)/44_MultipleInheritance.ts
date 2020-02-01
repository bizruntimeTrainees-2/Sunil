interface Iperson{
    name: string;
}
interface IEmployee{
    empCode: number;
}
class EmployeeDetails implements Iperson, IEmployee{
    empCode:number;
    name: string;

    constructor(Code:number, Name:string){
        this.empCode= Code;
        this.name = Name;
    }
    display():void {
        console.log("EmployeeName: " + this.name + ", EmployeeId: " + this.empCode);
        
    }
}
let objEmp = new EmployeeDetails(100, "Grifhender");
objEmp.display();