import { Observable } from 'rxjs';

const observable = Observable.create((observer : any) => {
    observer.next('Hey RxJS!');
});
observable.subscribe((x: any) => console.log(x));
 