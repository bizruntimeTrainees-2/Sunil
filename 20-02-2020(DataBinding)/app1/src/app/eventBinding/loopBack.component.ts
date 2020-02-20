import { Component } from '@angular/core';

@Component({
    selector: 'loopBack',
    template:
    `
    Enter Some Thing: <input #box (keyup.enter)="OnKey(box.value)">
    <p>{{value}}</p>
    `
})
export class LoopBackComponent{
    value = '';
    OnKey(value : string){
        this.value += value;
    }
}