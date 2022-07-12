import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from '../shared.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service: SharedService) { }
  table:any=[];
  nDung:any={
    TenDangNhap:'',
    MatKhau:''
  }
  
  taiKhoan:any
  matKhau:any
  
  
  ngOnInit(): void {
  
  }
  

  dangNhap(){
    this.nDung.tenDangNhap=this.taiKhoan
    this.nDung.matKhau=this.matKhau
    console.log(this.nDung)
    this.service.dangNhap(this.nDung).subscribe(data => {
    console.log(data)

    if(data!=null){
      alert("dang nhap thanh cong!")
       window.location.href = "http://localhost:4200/nhanVien";
    }else alert("dang nhap that bai!");
    })
  }

}
