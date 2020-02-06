import { zip, of } from "rxjs";
import { map } from "rxjs/operators";

let age$ = of<number> (27,26,52);
let name$ = of<string> ('foo', 'bar', 'net');
let isDev$ = of<boolean>(true, true, false);

zip(age$, name$, isDev$).pipe(
    map(([age, name, isDev]) => ({age, name, isDev})),
).subscribe(x => console.log(x));
