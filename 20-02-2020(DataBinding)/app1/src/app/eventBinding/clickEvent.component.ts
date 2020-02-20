import { Component } from '@angular/core';

@Component({
    selector: 'clickEvent',
    template: 
    `
    <button (click)='OnClick()'>Click Me!</button>
    alert({{clickMessage}});
    `
})
export class ClickEventComponent {
    clickMessage = '';
    OnClick(){
        this.clickMessage = "You are my Hero";
    }
}