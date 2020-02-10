import { of } from "rxjs";
import { catchError, map } from "rxjs/operators";

of(1,2,3,4,5,6,7,8).pipe(
    map(n => {
        if(n == 6){
            throw "six!"
        }
        return n;
    }),
    catchError(err => {
        throw 'error in source Details: ' + err;
    }),
)
.subscribe(
    x => console.log(x),
    err => console.log(err));
    