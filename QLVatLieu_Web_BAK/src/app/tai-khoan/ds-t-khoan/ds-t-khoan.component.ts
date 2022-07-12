import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-ds-t-khoan',
  templateUrl: './ds-t-khoan.component.html',
  styleUrls: ['./ds-t-khoan.component.css']
})
export class DsTKhoanComponent implements OnInit {

  constructor(private service:SharedService) { }
  DSTaiKhoan:any=[];
  tKhoan:any=[];
  dangThemSua:boolean=false;
  tieuDe:any

  ngOnInit(): void {
    this.tailaiDSTaiKhoan();
  }
  tailaiDSTaiKhoan(){
    this.service.layDSTaiKhoan().subscribe(data =>{
    this.DSTaiKhoan=data;
    })
  }

  themTaiKhoan(){
    
    this.dangThemSua=true;
    this.tKhoan.id=0;
    this.tieuDe="Thêm Tài Khoản"
  }

  chiTietTaiKhoan(tKhoan:any){
    this.tKhoan=tKhoan;
    this.dangThemSua=true;
    this.tieuDe="Sửa Tài Khoản"
  }
  xoaTaiKhoan(tKhoan:any){
   console.log(tKhoan.id)
    this.service.XoaTaiKhoan(tKhoan.id).subscribe(data=>{
      this.tailaiDSTaiKhoan()
    })}

  dong(){
    this.dangThemSua=false;
    location.reload()
    //this.tailaiDSTaiKhoan()
  }

}
