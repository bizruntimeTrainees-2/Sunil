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
var Per = /** @class */ (function () {
    function Per(Name) {
        this.name = Name;
    }
    Per.prototype.display = function () {
        console.log(this.name);
    };
    return Per;
}());
var Em = /** @class */ (function (_super) {
    __extends(Em, _super);
    function Em(name, Code) {
        var _this = _super.call(this, name) || this;
        _this.emCode = Code;
        return _this;
    }
    Em.prototype.find = function (name) {
        //Executes AJAX request to find an employeee fro  DB
        return new Em(name, 1);
    };
    return Em;
}(Per));
var em = new Em("James", 100);
em.display();
var em2 = em.find("ramu");
