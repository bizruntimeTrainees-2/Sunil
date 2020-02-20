import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
import { ClickEventComponent } from './eventBinding/clickEvent.component';
import { KeyUpComponent } from './eventBinding/keyUp.component';
import { LoopBackComponent } from './eventBinding/loopBack.component';
import { KeyUpBlurComponent } from './eventBinding/keyUpBlur.component';
import { NamesComponent } from './eventBinding/names.component';
import { InterComponent } from './interpolation/inter.component';
import { PropertyBindingComponent } from './PropertyBinding/property.component';
import { TwoWayComponent } from './twoWayDataBinding/twoway.component';


@NgModule({
  declarations: [
    AppComponent,
    CustomerComponent,
    ClickEventComponent,
    KeyUpComponent,
    LoopBackComponent,
    KeyUpBlurComponent,
    NamesComponent,
    InterComponent,
    PropertyBindingComponent,
    TwoWayComponent
  ],
  imports: [
    BrowserModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
