let greet = (greeting: string, ...name: string[])=>{
    return greeting + " " + name.join(", ") + "!";
}
console.log(greet("Hello", "Steve", "Bill"));
console.log(greet("Hello"));

