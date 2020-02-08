import { Subject, Observable } from "rxjs";

const subject = new Subject<string>();

subject.subscribe({
    next: (v)=> console.log("observable1 :" + v),
})
subject.subscribe({
    next: (v) => console.log("observable2 :" + v)
})

subject.next('1');
subject.next('2');
