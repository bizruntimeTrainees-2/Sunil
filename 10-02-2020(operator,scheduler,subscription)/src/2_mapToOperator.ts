import { mapTo } from "rxjs/operators";
import { from, interval } from "rxjs";

var observable = from(interval(2000));
var results = observable.pipe(mapTo("Only one constant every time"));
results.subscribe(val => console.log('*'));
results.subscribe(val => console.log('* *'));
results.subscribe(val => console.log('* * *'));
results.subscribe(val => console.log('* * * *'));
results.subscribe(val => console.log('* * * *'));
results.subscribe(val => console.log('  * * *'));
results.subscribe(val => console.log('    * *'));
results.subscribe(val => console.log('      *'));