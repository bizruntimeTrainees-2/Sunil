import { Observable, asyncScheduler } from "rxjs";
import { observeOn } from "rxjs/operators";

var observable = new Observable((observer) =>{
    observer.next(1);
    observer.next(2);
    observer.next(3);
    observer.next(4);
    observer.next(5)
    observer.complete();
}).pipe(observeOn(asyncScheduler));

console.log('Just Before AsynchScheduler');
observable.subscribe({next(x){
    console.log(x);    
},
error (err){
    console.log(err);    
},
complete(){
    console.log('done');
    
}
});
console.log('just after AsyncScheduler');

