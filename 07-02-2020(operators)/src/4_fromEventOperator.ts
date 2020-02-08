import { fromEvent} from "rxjs";

const clicksInDocument = fromEvent(document, "click");

const clicksInDiv = fromEvent(document, 'click');

clicksInDocument.subscribe(() => console.log('Document'));
clicksInDiv.subscribe(() => console.log('div'));
