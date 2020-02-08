import { fromEvent } from "rxjs";
import { delay } from "rxjs/operators";

var click =  fromEvent(document, 'click');
var delayClicks = click.pipe(delay(1000));

delayClicks.subscribe(() => console.log('clicked!'));
