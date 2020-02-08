import { BehaviorSubject } from "rxjs";

const subject = new BehaviorSubject(0);
subject.subscribe({
    next : (v) => console.log('ObserverA: ' + v)
    
});
subject.next(1);
subject.next(2);

subject.subscribe({
    next: (v) => console.log('ObserverB: ' + v)
    
});
subject.next(3);