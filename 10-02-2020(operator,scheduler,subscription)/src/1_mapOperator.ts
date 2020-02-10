import{from}from "rxjs";
import{map} from "rxjs/operators";

var observable = from([
    {name: "jack", age: 30},
    {name: "ron", age: 23},
    {name: "harry", age: 21},
    {name: "grifender", age: 56}
]);

// var results = observable.pipe(map(({name}) => name));
var results = observable.pipe(map(({age}) => age))
var subscribe = results.subscribe(val => console.log(val));

