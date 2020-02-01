"use strict";
;
function addKeyValue(key, value) {
    console.log("addKeyvalue: key " + key + " value " + value);
}
function updateKeyValue(key, value) {
    console.log("updateKeyValue: key " + key + " value " + value);
}
var kvp = addKeyValue;
kvp(1, "ravi");
kvp = updateKeyValue;
kvp(2, "erron");
