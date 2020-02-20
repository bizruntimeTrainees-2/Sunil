import { Component } from '@angular/core';
import {Customers} from './customers'

@Component({
    selector: 'customer',
    templateUrl:'./customer.component.html'
})
export class CustomerComponent {
    title = "Customers Details";
    cust = Customers;
    constructor(){

    }
}