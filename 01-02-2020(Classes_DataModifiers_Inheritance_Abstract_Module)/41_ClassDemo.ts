class Emp {
    empId : number;
    empName: string;

    constructor(code: number, name: string){
        this.empId = code;
        this.empName = name;
    }
    getSalary() : number{
        return 10000;
    }
}