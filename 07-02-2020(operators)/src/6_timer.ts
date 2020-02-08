import { timer } from "rxjs";

const time = timer(3000, 1000);
console.log("program starts after 3 seconds");

var subscription = time.subscribe(val => {
    console.log("2 * "+  val + " = " + 2 * val)}
    );
setTimeout(() =>{
    subscription.unsubscribe()
}, 10000)