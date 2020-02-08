import { combineLatest, of } from "rxjs";
import { delay, startWith } from "rxjs/operators";

const observable = [1,5,10].map(
    n => of(n).pipe(
        delay(n * 1000), // emit 0 immediatly and then emit n after n second
        startWith(0)
    )
);
const combinedLatest = combineLatest(observable);

combinedLatest.subscribe(x => console.log(x));
