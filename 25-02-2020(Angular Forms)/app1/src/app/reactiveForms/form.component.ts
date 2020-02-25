import { Component } from '@angular/core';
import {FormControl} from '@angular/forms';

@Component({
    selector: 'formsComponent',
    templateUrl: './form.component.html',
    styleUrls: ['./form.component.css']
})
export class FormComponent{
    pageTitle : string = "Reactive Forms";
    name = new FormControl('');
    public show : boolean = false;
    public buttonName : any = 'Show';
    upDateName(){
        this.name.setValue('Harry');
    }
    toggle(){
        this.show = !this.show

        if(this.show)
        this.buttonName = 'Hide';
        else
        this.buttonName = "Show";
    }
}