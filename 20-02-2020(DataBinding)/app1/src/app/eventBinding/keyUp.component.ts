import { Component } from '@angular/core';

@Component({
    selector: 'keyup',
    template: 
    `
    Type anything: <input (keyup)= OnKeyUp($event)>
    <p>{{value}}</p> &nbsp;&nbsp;
    `
})
export class KeyUpComponent{
    value = '';

    OnKeyUp(event : any){
        this.value += event.target.value + ' || ';
    }
}