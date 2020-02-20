import { Component } from '@angular/core';

@Component({
    selector: 'keyBlur',
    template:
    `
    Enter Some Thing: <input #box (keyUp.enter) = update(box.value)
    (blur)= update(box.value)>

    <p>{{value}}</p>
    `
})
export class KeyUpBlurComponent{
    value = '';

    update(value : any){
        this.value += value;
    }
}