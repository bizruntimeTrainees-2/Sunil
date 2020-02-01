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
var Car = /** @class */ (function () {
    function Car(Name) {
        this.name = Name;
    }
    Car.prototype.run = function (speed) {
        if (speed === void 0) { speed = 0; }
        console.log("A " + this.name + " is moving at " + speed + "mph!");
    };
    return Car;
}());
var Mercedes = /** @class */ (function (_super) {
    __extends(Mercedes, _super);
    function Mercedes(name) {
        return _super.call(this, name) || this;
    }
    Mercedes.prototype.run = function (speed) {
        if (speed === void 0) { speed = 150; }
        console.log("Mercedes Started");
        _super.prototype.run.call(this, speed);
    };
    return Mercedes;
}(Car));
var Honda = /** @class */ (function (_super) {
    __extends(Honda, _super);
    function Honda(name) {
        return _super.call(this, name) || this;
    }
    Honda.prototype.run = function (speed) {
        if (speed === void 0) { speed = 100; }
        console.log("Honda Started");
        _super.prototype.run.call(this, speed);
    };
    return Honda;
}(Car));
var mercObj = new Mercedes("Mercedes-Benz GLA");
var hondaObj = new Honda("Honda City");
mercObj.run();
hondaObj.run();
