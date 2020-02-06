import { Observable } from 'rxjs';

var observable = Observable.create((observe : any) => {
    observe.next("hello");
    observe.next("Hello Again");
    observe.complete();
    observe.next('Bye');
});
observable.subscribe(
    (x:any) => logItem(x),
    (error: any) => logItem ('Error: ' + error),
    () => logItem('Completed')
);
function logItem(val:any) {
    var node = document.createElement("li");
    var textnode = document.createTextNode(val);
    node.appendChild(textnode);
    document.getElementById("list").appendChild(node);
}