import { concat, interval } from "rxjs";
import { take } from "rxjs/operators";

const timer = interval(1000).pipe(take(2));

concat(timer, timer).subscribe(
    value => console.log(value),
    err => {},
    () => console.log(".......and it is!")
    
);