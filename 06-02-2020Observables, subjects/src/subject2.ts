import { Subject, from } from "rxjs";

const subject = new Subject<number>();

subject.subscribe({
    next : (v) => console.log("ObserverA: " + v),
});
subject.subscribe({
    next : (v) => console.log("ObserverB: " + v),
});

const observable = from([1,2,3]);

observable.subscribe(subject);
