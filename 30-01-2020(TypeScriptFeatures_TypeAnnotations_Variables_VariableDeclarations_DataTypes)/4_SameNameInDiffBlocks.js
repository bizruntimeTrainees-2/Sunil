"use strict";
var numb = 1;
function demo() {
    var numb = 2;
    if (true) {
        var num_1 = 3;
        console.log(numb);
    }
    console.log(numb);
}
console.log(numb);
demo();
