import { FormBuilder, FormArray } from '@angular/forms';
import { Component } from '@angular/core';

@Component({
    selector : "dynamicForms",
    templateUrl : './dynamic.component.html'
})
export class DynamicFormsComponent{
    pageTitle : string = "Dynamic FormControl";
    constructor(private fb: FormBuilder){}

    userProfileForm = this.fb.group({
        firstName : [''],
        lastName : [''],
        address : this.fb.array([
            this.fb.control('')
        ]),
        mobileNumber : this.fb.array([
            this.fb.control('')
        ])
    });
    get address(){
        return this.userProfileForm.get('address') as FormArray;
    }
    addMoreAddressFields(){
        this.address.push(this.fb.control(''));
    }
    get mobileNumber(){
        return this.userProfileForm.get('mobileNumber') as FormArray;
    }
    addMoreFields(){
        this.mobileNumber.push(this.fb.control(''));
    }
}