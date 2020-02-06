import { combineLatest, timer } from "rxjs";
import { first } from "rxjs/operators";

const firstTimer = timer(0,1000);
const secondTimer = timer(500, 1000);
const combinedTimers = combineLatest(firstTimer, secondTimer);
combinedTimers.subscribe(value => console.log(value));