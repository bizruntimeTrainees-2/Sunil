import { from, asyncScheduler } from "rxjs";

console.log("Start");


const array = [10, 20, 30, 40, 50];
const results = from(array, asyncScheduler);
results.subscribe(x => console.log(x));

console.log("end");
