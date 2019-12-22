import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { BrowserModule } from '@angular/platform-browser';
import { LayoutComponent } from './shared/layout/layout.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ChatComponent } from './chat/chat.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes =
  [
    {
      path: '',
      component: LayoutComponent,
      children: [
        { path: 'profile/:id', component: ProfileComponent },
        { path: 'chat', component: ChatComponent },
        { path: '**', component: NotFoundComponent }
      ]
    },
    { path: '**', component: NotFoundComponent },
    { path: 'forgotPassword', component: ForgotPasswordComponent },
    { path: 'loginPage', component: LoginPageComponent },
    { path: 'registration', component: RegistrationComponent}
  ];

@NgModule({
  imports: [BrowserModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
