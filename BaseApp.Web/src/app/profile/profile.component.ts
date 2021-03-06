import { Component } from '@angular/core';
import { UserService } from '../shared/services/user.service';

import { ActivatedRoute } from '@angular/router';



@Component({
  selector: 'profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent {

  public user;

  constructor(userService: UserService, private route: ActivatedRoute) {

    //Query Params
    this.route.queryParams.subscribe(params => {
      if (params.id != undefined) 
        this.user = userService.getUsersById(params.id);
    });
  }

  enableDisableRule(id) {
    this.posts.forEach(element => {
      if (element.id == id)
        element.toggle = !element.toggle
      element.status = element.toggle ? 'Enable' : 'Disable'
    });
  }
  
  //Like button
  like(id) {
    this.posts.forEach(element => {
      if (element.id == id)
        element.isLike = !element.isLike
    });
  }

  posts =
    [
      {
        title: 'With Friend!',
        image: "https://optim.kalashnikov.media/1080/https://cdn1.kalashnikov.media/prod/0c7af66b-8ba8-4d30-8b8c-a98ba47cc058",
        id: 1,
        isLike: false,
        toggle: true,
        status: 'Enable'
      },

      {
        title: 'With Friend!',
        image: "https://optim.kalashnikov.media/1080/https://cdn1.kalashnikov.media/prod/0c7af66b-8ba8-4d30-8b8c-a98ba47cc058",
        id: 2,
        isLike: false,
        toggle: true,
        status: 'Enable'
      },

      {
        title: 'Stupid people',
        image: "https://beztabu.net/uploads/770x433_DIR/media_news/2018/04/bb22ff8371aa50fe78e01fee556951f92aa83a42.jpg",
        id: 3,
        isLike: false,
        toggle: true,
        status: 'Enable'
      },

      {
        title: 'After New Year!',
        image: "https://cdn.defenseone.com/media/img/upload/2019/02/07/IMG_4170/defense-one-featured.jpg",
        id: 4,
        isLike: false,
        toggle: true,
        status: 'Enable'
      }

    ]

}





