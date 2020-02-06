import { merge, interval } from "rxjs";
import { take } from "rxjs/operators";

const timer1 = interval(1000).pipe(take(10));
const timer2 = interval(1000).pipe(take(5));
const timer3 = interval(1000).pipe(take(10));
const concurrent = 3;

const merged = merge(timer1, timer2, timer3, concurrent);
merged.subscribe(value => console.log(value));