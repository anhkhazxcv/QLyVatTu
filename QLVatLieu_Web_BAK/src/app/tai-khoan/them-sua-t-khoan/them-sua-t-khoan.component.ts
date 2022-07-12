import { Component, OnInit ,Input} from '@angular/core';
import { first } from 'rxjs';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-them-sua-t-khoan',
  templateUrl: './them-sua-t-khoan.component.html',
  styleUrls: ['./them-sua-t-khoan.component.css']
})
export class ThemSuaTKhoanComponent implements OnInit {

  MaTaiKhoan:any;
  TenDangNhap:any;
  MatKhau:any;
  NguoiSua:any; 
  NguoiThem:any;
  
  @Input() tKhoan:any;

  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.MaTaiKhoan = this.tKhoan.id;
    this.TenDangNhap = this.tKhoan.tenDangNhap;
    this.MatKhau=this.tKhoan.matKhau;
    this.NguoiThem = this.tKhoan.nguoiThem;
    this.NguoiSua=this.tKhoan.nguoiSua;

  }
  luuNV(){
    
    if (this.MaTaiKhoan==0) {
      
      this.themTaiKhoan()
      
    }
    else {
      
      this.suaTaiKhoan()
      
    }
  }
  themTaiKhoan(){
    var val = {
      tenDangNhap:this.TenDangNhap,  
      matKhau:this.MatKhau,
      nguoiThem:this.NguoiThem,
      nguoiSua:" "
    };
    console.log(val)
   this.service.ThemTaiKhoan(val).pipe(first()).subscribe(res=>{
    console.log(res); 
   location.reload();
   })
  }
  suaTaiKhoan(){
    var val = {
      id:this.MaTaiKhoan,
      tenDangNhap:this.TenDangNhap, 
      matKhau:this.MatKhau,
      nguoiThem:" ",
      nguoiSua:this.NguoiSua
    };
    this.service.suaTaiKhoan(val).pipe(first()).subscribe(res=>{
    console.log(res);
    location.reload();
    })
    }
  
}
