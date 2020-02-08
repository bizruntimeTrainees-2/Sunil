import { from } from "rxjs";
import { take } from "rxjs/operators";
//converting infinite iterable to an observable


var iterator = generateDoubles(1);
var result = from(iterator).pipe(take(3));

result.subscribe(x => console.log(x));

function* generateDoubles(val : number){
    let i = val;
    while(true){
        yield i;
        i = 2 * i;
    }
}