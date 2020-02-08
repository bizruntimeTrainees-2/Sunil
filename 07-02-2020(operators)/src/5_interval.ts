import { interval, of } from "rxjs";
import { take } from "rxjs/operators";

const number = interval(1000);
const count = number.pipe(take(100));

count.subscribe(val => {
    // if(val % 5 == 0){
        console.log(val);
        
    // }
})