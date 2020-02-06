import { ajax } from "rxjs/ajax";
import { map, catchError } from "rxjs/operators";
import { of } from "rxjs";

const obs = ajax.getJSON(`https://api.github.com/users?per_page=5`).pipe(
    map(userResponse => console.log("user: ", userResponse)),
    catchError(error => {
        console.log('error', error);
        return (error);
    })
);
const subscribe = obs.subscribe(
    val => console.log(val));