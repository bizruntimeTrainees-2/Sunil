"use strict";
function throwError(errorMsg) {
    throw new Error(errorMsg);
}
function keepProcessing() {
    while (true) {
        console.log("I always dose somthing never end");
    }
}
