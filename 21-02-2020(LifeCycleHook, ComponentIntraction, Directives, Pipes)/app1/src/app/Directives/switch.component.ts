import { Component } from '@angular/core';

@Component({
    selector: 'switchDirective',
    templateUrl: './switch.component.html'
})
export class SwitchComponent{
    selectedCountry : string;
    countries : any[] = [
        {code : 'ind', country : 'India'},
        {code : 'uae', country : 'United Arab Emirates'},
        {code : 'uk', country : 'United Kingdom'},
        {code : 'aus', country : 'Australia'}
    ];

    choice(code){
        this.selectedCountry = code;
    }
}