import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


import { 
    MatButtonModule,
    MatButtonToggleModule,
    MatSlideToggleModule,
    MatSidenavModule,
    MatCardModule,
    MatTabsModule,
    MatGridListModule } from '@angular/material';
    

const MaterialComponents = [
    MatButtonModule,
    MatButtonToggleModule,
    MatSlideToggleModule,
    MatSidenavModule,
    MatCardModule,
    MatTabsModule,
    MatGridListModule
];

@NgModule({
imports: [MaterialComponents],
exports: [MaterialComponents]
})


export class MaterialAppModule { }



  

