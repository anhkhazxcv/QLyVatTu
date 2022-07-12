import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-ds-n-vien',
  templateUrl: './ds-n-vien.component.html',
  styleUrls: ['./ds-n-vien.component.css']
})
export class DsNVienComponent implements OnInit {

  constructor(private service:SharedService ) {}
  DSNhanVien:any=[];
  nVien:any=[];
  dangThemSua:boolean=false;
  tieuDe:any

  ngOnInit(): void {
    this.tailaiDSNhanVien();
  }
  tailaiDSNhanVien(){
    this.service.layDSNhanVien().subscribe(data =>{
    this.DSNhanVien=data;
    })
  }

  themNhanVien(){
    this.dangThemSua=true;
    this.nVien.idnv=0;
    this.tieuDe="Thêm Nhân Viên"
  }

  chiTietNhanVien(nVien:any){
    this.nVien=nVien;
    console.log(nVien)
    this.dangThemSua=true;
    this.tieuDe="Sửa Nhân Viên"
  }
  xoaNhanVien(nVien:any){
   
    this.service.XoaNhanVien(nVien.idnv).subscribe(data=>{
      this.tailaiDSNhanVien()
    })}

  dong(){
    this.dangThemSua=false;
    location.reload()
    //this.tailaiDSNhanVien()
  }
}
