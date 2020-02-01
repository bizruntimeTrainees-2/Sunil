"use strict";
var Circle = /** @class */ (function () {
    function Circle() {
        this.pi = 3;
    }
    Circle.pi = 3.14;
    return Circle;
}());
console.log(Circle.pi);
var circleObj = new Circle();
console.log(circleObj.pi);
