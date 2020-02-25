import { Component } from '@angular/core';
import {FormBuilder} from '@angular/forms'
@Component({
    selector: 'formbuilder',
    templateUrl: './formBuilder.component.html'
})
export class FormBuilderComponent{
    pageTitle : string = 'Forms using form builder';
    show : boolean = false;
    buttonName : any = 'Show';
    constructor(private fb : FormBuilder){

    }
    userInputData = this.fb.group({
        firstName: [''],
        lastName : [''],
        address : this.fb.group({
            address1 : [''],
            address2 : [''],
            state : [''],
        })
    });
    toggle(){
        this.show = !this.show;
        if(this.show){
            this.buttonName = "Hide";
        }else this.buttonName = "Show";
    }
}