import { combineLatest, timer } from "rxjs";

var firsttimer = timer(0,1000);
var secondtimer = timer(0, 500);

var CombinedTimers = combineLatest(firsttimer, secondtimer);

var subscription = CombinedTimers.subscribe(val => console.log(val));

setTimeout(() => {
    subscription.unsubscribe();
}, 10000);
