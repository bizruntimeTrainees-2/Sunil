"use strict";
var EmployeeDetails = /** @class */ (function () {
    function EmployeeDetails(Code, Name) {
        this.empCode = Code;
        this.name = Name;
    }
    EmployeeDetails.prototype.display = function () {
        console.log("EmployeeName: " + this.name + ", EmployeeId: " + this.empCode);
    };
    return EmployeeDetails;
}());
var objEmp = new EmployeeDetails(100, "Grifhender");
objEmp.display();
