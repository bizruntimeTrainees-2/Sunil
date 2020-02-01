"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Person = /** @class */ (function () {
    function Person(name) {
        this.empName = name;
    }
    return Person;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(code, name) {
        var _this = _super.call(this, name) || this;
        _this.empCode = code;
        return _this;
    }
    Employee.prototype.displayName = function () {
        console.log("Name: " + this.empName + " With employeeId: " + this.empCode);
    };
    return Employee;
}(Person));
var empObj = new Employee(100, "Ron  Wesely");
empObj.displayName();
