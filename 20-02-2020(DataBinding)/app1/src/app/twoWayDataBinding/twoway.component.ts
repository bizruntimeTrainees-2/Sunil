import { Component } from '@angular/core';

@Component({
    selector : 'twoWayDataBinding',
    templateUrl: './twoWay.component.html'
})
export class TwoWayComponent{
    pageTitle : string = 'Two way data binding';
    userName : string = "";
}