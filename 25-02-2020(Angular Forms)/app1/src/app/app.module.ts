import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {ReactiveFormsModule} from '@angular/forms'
import { FormComponent } from './reactiveForms/form.component';
import { FormGroupComponent } from './reactiveForms/formGroup/formgroup.component';
import { FormBuilderComponent } from './reactiveForms/formGroup/formBuilder.component';

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    FormGroupComponent,
    FormBuilderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
