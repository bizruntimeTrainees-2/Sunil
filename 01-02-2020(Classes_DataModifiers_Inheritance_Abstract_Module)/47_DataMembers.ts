class EmpDe{
    public EmpName: string;
    protected EmpCode: number;

    constructor(name: string, code: number){
        this.EmpName=name;
        this.EmpCode=code;
    }
}
class SalesEmployee extends Emp{
 //   private department: string;

   /* constructor(name: string, code: number, department: string){
       super(name, code);
        this.department=department;
    }*/
}