function displayType(code: (number | string)){
    if(typeof(code) === "number"){
        console.log("Code is number");        
    }
    else if(typeof(code) === "string"){
        console.log("Code is String");        
    }
}
displayType(123);
displayType("ABC"); 