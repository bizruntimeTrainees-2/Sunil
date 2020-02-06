import { interval } from "rxjs";

const obervable = interval(1000);
const subscription = obervable.subscribe(x => console.log(x));
subscription.unsubscribe();