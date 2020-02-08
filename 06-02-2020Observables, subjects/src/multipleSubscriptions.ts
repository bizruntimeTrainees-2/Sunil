import { Observable } from "rxjs";

const observable = Observable.create((observer : any) => {
   setInterval(() =>{
       observer.next("hi!");
   }, 1000);
    
});
var sub1 = observable.subscribe((x : any) => console.log(x));
var sub2 = observable.subscribe((x : any) => console.log(x));
setTimeout(() => {
    sub1.unsubscribe();
    sub2.unsubscribe();
},3000);
