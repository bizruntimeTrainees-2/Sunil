"use strict";
var Student = /** @class */ (function () {
    function Student(name, rollNo) {
        this.name = name;
        this.rollNo = rollNo;
    }
    return Student;
}());
var student = new Student("raghu", 43);
console.log(student.name);
console.log(student.rollNo);
