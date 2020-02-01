class Student{
    name: string;
    rollNo: number;

    constructor(name:string, rollNo: number){
        this.name=name;
        this.rollNo=rollNo;
    }
}
let student = new Student("raghu", 43);
console.log(student.name);
console.log(student.rollNo);