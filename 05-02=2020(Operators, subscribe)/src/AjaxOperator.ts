import {ajax} from 'rxjs/ajax';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

const abs$ = ajax("https://api.github.com/users?per_page=5").pipe(
    map(userResponse => console.log('user', userResponse)),
    catchError(error => {
        console.log('error', error);
        return (error)
    })
);
const subscribe = abs$.subscribe(
    val => console.log(val))