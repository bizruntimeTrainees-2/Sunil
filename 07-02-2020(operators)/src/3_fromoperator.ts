import { from, asyncScheduler } from "rxjs";

console.log("start");

const arr = [1,2,3,4,5,6,7];
const results = from(arr, asyncScheduler);

results.subscribe(x => {
    if(x % 2 == 0){
        console.log(x + x * x);
        
    }
});
console.log("end");
