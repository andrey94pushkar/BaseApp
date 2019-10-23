import { Component, OnInit } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

public PhotoIt = ["1","2","3","4"];
  
//Like Button
condition: boolean=true;
     
    like(){
        this.condition=!this.condition;
    }
    

  // SidenavOpen
  mode = new FormControl ( 'side' );
  

  constructor() { }

  ngOnInit() {
  }

}
interface Tile {
     color: string;
     cols: number;
     rows: number;
     text: string;
}




