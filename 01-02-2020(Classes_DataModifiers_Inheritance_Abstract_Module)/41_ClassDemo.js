"use strict";
var Emp = /** @class */ (function () {
    function Emp(code, name) {
        this.empId = code;
        this.empName = name;
    }
    Emp.prototype.getSalary = function () {
        return 10000;
    };
    return Emp;
}());
