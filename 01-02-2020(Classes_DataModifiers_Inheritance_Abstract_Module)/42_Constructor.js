"use strict";
var Idea = /** @class */ (function () {
    function Idea(Name, Age) {
        this.name = Name;
        this.age = Age;
    }
    return Idea;
}());
var obj = new Idea("Steve", 20);
console.log("Name: " + obj.name);
console.log("Age: " + obj.age);
