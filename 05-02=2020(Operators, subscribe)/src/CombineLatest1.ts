import { combineLatest, of } from "rxjs";
import { startWith, delay } from "rxjs/operators";


const observable = [1, 2, 3, 4, 5].map(
    n => of(n).pipe(
        delay(n * 1000),
        startWith(0),
    )
);
const combined = combineLatest(observable);
combined.subscribe(value => console.log(value));