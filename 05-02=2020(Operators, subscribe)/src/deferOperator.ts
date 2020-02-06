import { defer, fromEvent, interval } from "rxjs";

const Interval = defer(() =>{
    return Math.random() > 0.5 
    ? fromEvent(document, 'click')
    : interval(1000);
});
Interval.subscribe(x => console.log(x));