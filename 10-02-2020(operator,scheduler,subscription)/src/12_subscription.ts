import { interval, observable } from "rxjs";

const observable1 = interval(400);
const observable2 = interval(300);

var subscription = observable1.subscribe(x => console.log('first: ' + x));
var childSubscription = observable2.subscribe(x => console.log('second: ' + x));

setTimeout(() => {
    subscription.unsubscribe();
    childSubscription.unsubscribe();
}, 1000);