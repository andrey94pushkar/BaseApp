import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { BrowserModule } from '@angular/platform-browser';
import { LayoutComponent } from './shared/layout/layout.component';
import { PreloaderComponent } from './shared/preloader/preloader.component';
import { NotFoundComponent } from './not-found/not-found.component';





const routes: Routes = 
[
  {path:'',component:ProfileComponent},
  {path:'profile',component:ProfileComponent},
  {path:'forgotPassword',component:ForgotPasswordComponent},
  {path:'layout',component:LayoutComponent},
  {path: '**', component: NotFoundComponent}
  {path:'layout',component:LayoutComponent},
  {path:'preloader',component:PreloaderComponent}
];

@NgModule({
  imports: [BrowserModule,RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
