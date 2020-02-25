import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {ReactiveFormsModule, FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { DynamicFormsComponent } from './DynamicFormControls/dynamic.component';
import { SuperHeroesComponent } from './templateDrivenForms/superHeroes.component';

@NgModule({
  declarations: [
    AppComponent,
    DynamicFormsComponent,
    SuperHeroesComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
