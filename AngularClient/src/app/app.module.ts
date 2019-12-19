import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatButtonModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProfileComponent } from './profile/profile.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { FormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LayoutComponent } from './shared/layout/layout.component';
import { MatBadgeModule } from '@angular/material/badge';
import { NotFoundComponent } from './not-found/not-found.component';
import { CommonModule } from '@angular/common';
import { ContactsComponent } from './shared/components/contacts/contacts.component';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { MatMenuModule} from '@angular/material/menu';
import { UserService } from './shared/services/user.service';
import { PreloaderComponent } from './shared/components/preloader/preloader.component';
import { ChatComponent } from './chat/chat.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { RegistrationComponent } from './registration/registration.component';
import { ShareDialogComponent } from './share-dialog/share-dialog.component';
import { UserSettingsComponent } from './user-settings/user-settings.component';
import {MatNativeDateModule} from '@angular/material/';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MenuComponent } from './menu/menu.component';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
import {MatDialogModule} from '@angular/material/dialog';
import { SettingsDialogComponent } from './settings-dialog/settings-dialog.component';


@NgModule({
  declarations: [
    AppComponent,
    ProfileComponent,
    ForgotPasswordComponent,
    LayoutComponent,
    NotFoundComponent,
    ContactsComponent,
    PreloaderComponent,
    ChatComponent,
    LoginPageComponent,
    RegistrationComponent,
    ShareDialogComponent,
    UserSettingsComponent,
    MenuComponent,
    SettingsDialogComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    MatInputModule,
    MatListModule,
    MatIconModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatSidenavModule,
    MatGridListModule,
    MatCardModule,
    MatSelectModule,
    MatRadioModule,
    MatBadgeModule,
    MatMenuModule,
    MatNativeDateModule,
    MatCheckboxModule,
    MatDatepickerModule,
    MatSlideToggleModule,
    MatDialogModule

  ],
  entryComponents: [
    SettingsDialogComponent,
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})

export class AppModule { }