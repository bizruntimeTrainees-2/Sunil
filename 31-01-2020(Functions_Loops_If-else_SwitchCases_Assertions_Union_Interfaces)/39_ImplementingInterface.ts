interface IEmp {
    empCode: number;
    name: string;
    //getSalary:(number)=>number;
}
class Emp implements IEmp{
    empCode: number;
    name: string;

    constructor(code: number, name:string){
        this.empCode = code;
        this.name = name
    }
    getSalary(empCode: number):number{
        return 20000;
    }
}