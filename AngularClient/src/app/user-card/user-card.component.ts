import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-card',
  templateUrl: './user-card.component.html',
  styleUrls: ['./user-card.component.css']
})
export class UserCardComponent implements OnInit {

  condition: boolean=true;
     
    like(i){
        this.condition=!this.condition;
        
    }
    image:any;
    records = 
    [
      {
        title : 'ED1',
        image : "https://cdn.defenseone.com/media/img/upload/2019/02/07/IMG_4170/defense-one-featured.jpg"
      
      },

      {
        title : 'ED2',
        image : "https://optim.kalashnikov.media/1080/https://cdn1.kalashnikov.media/prod/0c7af66b-8ba8-4d30-8b8c-a98ba47cc058"
      },
      {
        title : 'ED1',
        image : "https://cdn.defenseone.com/media/img/upload/2019/02/07/IMG_4170/defense-one-featured.jpg"
      
      },

      {
        title : 'ED2',
        image : "https://optim.kalashnikov.media/1080/https://cdn1.kalashnikov.media/prod/0c7af66b-8ba8-4d30-8b8c-a98ba47cc058"
      }

    ]
    card:any;
  constructor() { 
    // this.card = {
      
    //   title : 
    //   [
    //     'ED1',
    //     'ED2'
    //   ],
    //   phone:
    //   [
    //     '32323',
    //     '32424'
    //   ],
    //   image:
    //   [
    //     // 'url(https://optim.kalashnikov.media/1080/https://cdn1.kalashnikov.media/prod/0c7af66b-8ba8-4d30-8b8c-a98ba47cc058)',
    //     // 'url(https://cdn.defenseone.com/media/img/upload/2019/02/07/IMG_4170/defense-one-featured.jpg)'
        
    //   ]
    
    // }
    
  }

  ngOnInit() {
  }

}
