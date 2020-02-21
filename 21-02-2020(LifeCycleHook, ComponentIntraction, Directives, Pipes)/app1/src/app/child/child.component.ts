import { Component, Input, Output, EventEmitter } from '@angular/core';


@Component({
    selector: 'app-child',
    template: `
        <div>
            <h3>This is child component</h3>
            <button (click)='passData()'>Sent data</button>
        </div>
    `,
    styles: [`
        div{
            background-color: lightgray;
            padding: 20px;
            color:peru;
            margin-right: 75%;
        }
    `]
})
export class ChildComponent {
   // @Input() uName :string 
   @Output()
   data : EventEmitter<string> = new EventEmitter<string>();

   passData(){
       this.data.emit("Data back to parent component from child component");
   }
}