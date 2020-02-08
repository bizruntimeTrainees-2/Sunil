import { concat, range, interval } from "rxjs";
import { take } from "rxjs/operators";

const timer = interval(1000).pipe(take(4));
var sequence = range(10, 20);
const result = concat(timer, sequence);

result.subscribe(val => console.log(val));
