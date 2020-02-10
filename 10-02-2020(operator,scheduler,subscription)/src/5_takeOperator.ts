import { take } from "rxjs/operators";
import { interval } from "rxjs";

var count = interval(1000);
var  result = count.pipe(take(10));
result.subscribe(val => console.log(val));
