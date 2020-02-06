import { of, interval, zip, merge } from "rxjs";
import { map, publish, tap, multicast } from "rxjs/operators";

const sources$ = zip(interval(2000), of(1,2,3,4,5,6,7,8,9)).pipe(
    map(values => values[1])
);
sources$.pipe(
    publish(multicasted$ => 
        merge(
            multicasted$.pipe(tap(x => console.log('Stream1: ' + x))),
            multicasted$.pipe(tap(x => console.log('stream2: ' + x))),
            multicasted$.pipe(tap(x => console.log('stream3: ' + x)))
        )
    )
)
.subscribe();