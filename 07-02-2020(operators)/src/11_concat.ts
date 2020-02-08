import { concat, interval } from 'rxjs';
import { take } from 'rxjs/operators';
 
const timer1 = interval(1000).pipe(take(10));
const timer2 = interval(1000).pipe(take(6));
const timer3 = interval(1000).pipe(take(2));
 
const result = concat(timer1, timer2, timer3);
result.subscribe(x => console.log(x));
