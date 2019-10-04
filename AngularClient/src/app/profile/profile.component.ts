import { Component, OnInit } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  
  // SidenavOpen
  mode = new FormControl ( 'side' );
  
  // GridList
  tiles: Tile[] = [
    {text: 'One', cols: 3, rows: 1, color: 'black'},
    {text: 'Two', cols: 1, rows: 2, color: 'lightgreen'},
    {text: 'Three', cols: 1, rows: 1, color: 'lightpink'},
    {text: 'Four', cols: 2, rows: 1, color: '#DDBDF1'},
  ];
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




