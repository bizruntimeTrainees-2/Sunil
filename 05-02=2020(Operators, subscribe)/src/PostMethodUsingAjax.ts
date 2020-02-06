import { ajax } from "rxjs/ajax";
import { of } from "rxjs";
import { map, catchError } from "rxjs/operators";

const user = ajax({
    url: 'https://httpbin.org/delay/2',
    method: 'post',
    headers: {
        Content_Type: 'application/json',
        'rxjs-custom-header': 'Rxjs'
    },
    body:{
        rxjs: "Hello World!"
    }
}).pipe(
    map(response => console.log("response", response)),
    catchError(error =>{
        console.log('error', error);
        return(error);
    })
);
const subscribe = user.subscribe(
    v => console.log(v)
    
);