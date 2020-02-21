import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { OnchangeComponent } from './LifecycleHook/OnChange.component';
import { SwitchComponent } from './Directives/switch.component';
import { ChildComponent } from './child/child.component';
import { PipeComponent } from './pipes/pipe.component';

@NgModule({
  declarations: [
    AppComponent,
    OnchangeComponent,
    SwitchComponent,
    ChildComponent,
    PipeComponent
  ],
  imports: [
    BrowserModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
