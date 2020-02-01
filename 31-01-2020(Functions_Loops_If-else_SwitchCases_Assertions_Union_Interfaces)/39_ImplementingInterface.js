"use strict";
var Emp = /** @class */ (function () {
    function Emp(code, name) {
        this.empCode = code;
        this.name = name;
    }
    Emp.prototype.getSalary = function (empCode) {
        return 20000;
    };
    return Emp;
}());
