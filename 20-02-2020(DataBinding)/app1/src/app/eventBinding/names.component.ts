import { Component } from '@angular/core';

@Component({
    selector: 'names',
    template: 
    `
    Names : <input #text
            (keyup.enter)= "addNames(text.value)"
            (blur)="addNames(text.value); text.value=''">
            <button (click)= "addNames(text.value)">Add</button>

            <ul><li *ngFor="let name of names">{{name}}</li></ul>
    `
})
export class NamesComponent{
    names = ['hello', 'vijay', 'sana', 'antony'];

    addNames(names : string){
        if(names){
            this.names.push(names);
        }
    }

}