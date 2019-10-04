import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatButtonModule} from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialAppModule } from './material/ngmaterial.module';
import { ProfileComponent } from './profile/profile.component';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatSidenavModule} from '@angular/material/sidenav';
import {FormsModule} from '@angular/forms';
import {MatInputModule, MatInput} from '@angular/material/input';
import {FormControl} from  '@angular/forms';
import {MatListModule} from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon';
// import { Validators} from '@angular/forms';
import {MatFormFieldModule} from '@angular/material/form-field';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import {ReactiveFormsModule} from '@angular/forms';
import { LayoutComponent } from './layout/layout.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatSidenavModule} from '@angular/material/sidenav';



@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent,
    ForgotPasswordComponent

    AppComponent,
    LayoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatButtonModule,
    BrowserAnimationsModule,
    MaterialAppModule,
    MatGridListModule,
    MatSidenavModule,
    FormsModule,
    MatInputModule,
    MatInputModule,
    MatListModule,
    MatIconModule,
    MatFormFieldModule,
    ReactiveFormsModule
    
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
export class CheckboxOverviewExample {}
export class ButtonOverviewExample {}




