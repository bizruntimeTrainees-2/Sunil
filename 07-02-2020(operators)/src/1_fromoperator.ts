import { from } from 'rxjs'

var arr = ([1,2,3,4,5]);
var result = from(arr);

result.subscribe(x => console.log(x * x));
