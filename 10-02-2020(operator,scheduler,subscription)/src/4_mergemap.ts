import { of, interval, from } from "rxjs";
import { mergeMap, map } from "rxjs/operators";

var  letters = of(10);
var results = letters.pipe(mergeMap(x => interval(1000).pipe(map(i => x*i))));
results.subscribe(val => console.log(val));
