interface IStudent{
    name:string;
    rollNo:number;
}
let emp1 : Readonly<IStudent> = {
    name : "Steve",
    rollNo : 1
}
//emp1.name = "faai";
//emp1.rollNo= 2;