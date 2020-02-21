import { Component } from '@angular/core';

@Component({
    selector: 'pipeComponent',
    templateUrl: './pipe.component.html'
})
export class PipeComponent{
    pageTitle : string = 'Pipes in angular';

    users : any[] = [
        {id: 101, name: "john", city: 'DELHI', salary: 20000, dob:new Date("05/10/1989")},
        {id: 102, name: "robert", city: 'PUNE', salary: 20500, dob:new Date("05/10/1999")},
        {id: 103, name: "salim", city: 'GOA', salary: 40000, dob:new Date("05/10/1979")},
        {id: 101, name: "ron", city: 'MUMBAI', salary: 50000, dob:new Date("05/10/1990")},
    ];
}