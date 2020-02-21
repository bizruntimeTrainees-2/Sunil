import { Component, OnChanges, SimpleChanges } from '@angular/core';

@Component({
    selector: "onchange",
    templateUrl: "./OnChange.component.html"
})
export class OnchangeComponent implements OnChanges{
    pageTitle : string = 'ngOnChanges hook';
     UserText : string

    ngOnChanges(changes : SimpleChanges){
        for(let propertyName in changes){
            let change = changes[propertyName];
            let current = JSON.stringify(change.currentValue);
            let previous = JSON.stringify(change.previousValue);
            console.log(propertyName + ' : currentValue ' + current + ' , previousValue' + previous);
            

        }
    }
}