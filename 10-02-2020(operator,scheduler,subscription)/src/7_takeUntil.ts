import { takeUntil } from "rxjs/operators";
import { interval, fromEvent } from "rxjs";

var count  = interval(1000);
var clicks = fromEvent(document, "click");
var results = count.pipe(takeUntil(clicks));
results.subscribe(x => console.log(x));