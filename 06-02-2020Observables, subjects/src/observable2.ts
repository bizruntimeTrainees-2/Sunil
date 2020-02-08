import { Observable } from "rxjs";

const observable = Observable.create((observer : any) => {
    observer.next("Iam");
    observer.next("Rxjs");
    observer.next ("Iam new to this world");
 
    observer.next("Hello are you there");
    observer.error();
});
observable.subscribe((x: any) => console.log(x));
observable.subscribe((x: any) => console.log(x));
