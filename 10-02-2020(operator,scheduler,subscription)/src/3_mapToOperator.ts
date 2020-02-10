import { fromEvent } from "rxjs";
import { mapTo } from "rxjs/operators";

var observable = fromEvent(document, "click");
var results = observable.pipe(mapTo("Clicked on document"));
results.subscribe(val => console.log(val));
