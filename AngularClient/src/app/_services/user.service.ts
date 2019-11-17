import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() { }
  public users =
  [
    
    {
      id: 1,
      firstName: 'Dart',
      lastName: 'Vaider',
      country: 'Distant Galaxy',
      birthday: '03.03.0003',
      avatar : "https://cdn-st1.rtr-vesti.ru/p/xw_1138944.jpg",
      logo:"https://toptos.com.ua/content/images/5/populyarnyy-popsoket-pop-socket-dlya-parnya-dart-veyder-56860954500598_small11.jpg",
      status:'SPACE DIRECTOR'
    },
    {
      id: 2,
      firstName: 'Harley',
      lastName: 'Quean',
      country: 'USA',
      birthday: '02.02.0002',
      avatar : "https://www.soyuz.ru/public/uploads/files/2/7234415/201811211258136d8102972b.jpg",
      logo:"https://24smi.org/public/media/person/2017/11/28/3xrsu8dknklx-kharli-kvinn.jpg",
      status:'PROFESSIONAL CRIMINAL'
    },
    {
      id: 3,
      firstName: 'Sherlock',
      lastName: 'Holmes',
      country: 'England',
      birthday: '01.01.0001',
      avatar : "https://volginblog.files.wordpress.com/2017/02/d0bcd0b8d0bdd0b8d0b0d182d18ed180d0b0.jpg?w=605",
      logo:"https://images.ua.prom.st/1921214880_w640_h640_kniga-dumati-yak.jpg",
      status:'DETECTIVE-FREELANCER'
    },
  ]
  getUsersById(id) {

    let user = this.users
    return user.find(user => user.id === id);
  }
}
