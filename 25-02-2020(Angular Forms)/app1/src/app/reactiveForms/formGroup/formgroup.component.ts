import { Component } from '@angular/core';
import {FormGroup, FormControl, FormControlName} from '@angular/forms'
@Component({
    selector: 'fromgroup',
    templateUrl: './formgroup.component.html'
})
export class FormGroupComponent{
    pageTitle= "Froms Group";
    userInputData = new FormGroup({
        firstName : new FormControl(''),
        lastName : new FormControl(''),
        age: new FormControl(''),
        email : new FormControl(''), 
            address : new FormGroup({
                address1 : new FormControl(''),
                address2 : new FormControl(''),
        }),
    });

    onSubmit(){
        console.log(this.userInputData.value);
    }
}