"use strict";
var greet = function (greeting) {
    var name = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        name[_i - 1] = arguments[_i];
    }
    return greeting + " " + name.join(", ") + "!";
};
console.log(greet("Hello", "Steve", "Bill"));
console.log(greet("Hello"));
