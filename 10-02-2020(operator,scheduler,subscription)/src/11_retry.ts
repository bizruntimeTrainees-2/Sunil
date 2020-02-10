import { retry, mergeMap, catchError } from "rxjs/operators";
import { of, interval, throwError } from "rxjs";

const source = interval(1000);
const ex = source.pipe(
    mergeMap(val => {
        if(val > 5){
            return throwError('error');
        }
        return of(val);
    }),
    retry(1)
);
var subscribe = ex.subscribe({
    next : val => console.log(val),
    error : val => console.log(val +  ':  Retried 2 times then Quit!')
});