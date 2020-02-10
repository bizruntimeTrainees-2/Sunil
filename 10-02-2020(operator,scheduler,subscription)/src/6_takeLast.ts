import { takeLast } from "rxjs/operators";
import { range } from "rxjs";

var count = range(1, 100);
var result = count.pipe(takeLast(3));
result.subscribe(x => console.log(x));