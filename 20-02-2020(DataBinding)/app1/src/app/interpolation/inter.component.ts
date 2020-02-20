import { Component } from '@angular/core';

@Component({
    selector: 'interBinding',
    templateUrl: './inter.component.html'
})
export class InterComponent {
    pageTitle : String = "Interpolation Binding";
    imageUrl = "assets/images/bmw.jpg";
}