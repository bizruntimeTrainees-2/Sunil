import { Observable } from "rxjs";

const observable = Observable.create((observer : any) => {
    observer.next("Hey");
    observer.next("H R U?");
    setInterval(() =>{
        observer.next("Iam Good");
    }, 1000);
});
const subscription = observable.subscribe((x: any) => console.log(x));

setTimeout(() => {
    subscription.unsubscribe();
}, 2001);