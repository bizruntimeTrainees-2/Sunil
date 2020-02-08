import { Observable } from "rxjs";

const observable = Observable.create((observer : any) => {
    observer.next("hi!");
    observer.next("Hello");
    setInterval(() => {
        observer.next("good");
    }, 2000);
});
var subscription = observable.subscribe((x: any) => console.log(x));

setTimeout(() => {
    var subscription2 = observable.subscribe((x: any) => console.log('Subscription2: ' + x));
}, 1000);