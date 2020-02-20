import { Component } from '@angular/core';

@Component({
    selector: 'propertyBinding',
    templateUrl: './property.component.html' 
})
export class PropertyBindingComponent{
    pageTitle : string = 'This is property binding';
    imageUrl = 'assets/images/bmw.jpg';
}