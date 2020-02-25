import { Component } from '@angular/core';
import {SuperHeros} from './superHeros';
@Component({
    selector: 'superHerosComponent',
    templateUrl: './superHeroes.component.html'
})
export class SuperHeroesComponent{
    pageTitle : string = 'Template driven form';
    weapon = ['Iron Suit', 'Hammer', 'Bow And Arrow', 'Sheild', 'Raw Power'];

    speciality= ['Technology', 'God of Thunders', 'Archer', 'war and Leadership', 'Scientist'];

    model = new SuperHeros(1, 'Iron Man', this.weapon[0], this.speciality[0], 'Tony Stark');
}