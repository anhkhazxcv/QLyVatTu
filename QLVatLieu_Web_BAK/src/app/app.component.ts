import { Component ,OnInit} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'QLVatLieu';
  loginn:boolean=true
  check:boolean=false
  ngOnInit(): void {
    // if(window.location.href =="http://localhost:4200/nhanVien") this.loginn=true;
    // else {this.loginn=false
    // this.check=true
    // }
  } 
  
}
