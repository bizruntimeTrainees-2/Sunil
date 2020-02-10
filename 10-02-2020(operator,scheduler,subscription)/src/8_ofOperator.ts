import { of } from "rxjs";

var count = of(1,2,3,4,5,6,7,8,9);
count.subscribe(x => console.log(x));