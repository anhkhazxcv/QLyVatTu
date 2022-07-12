import { Component, OnInit,Input } from '@angular/core';
import { first } from 'rxjs';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-them-sua-n-vien',
  templateUrl: './them-sua-n-vien.component.html',
  styleUrls: ['./them-sua-n-vien.component.css']
})
export class ThemSuaNVienComponent implements OnInit {
  maNhanVien:any;
  tenNhanVien:any;
  gioiTinh:any;
  ngaySinh:any;
  diaChi:any;
  soDienThoai:any;
  cmnd:any;
  IDPhongBan:any;
  idNhomQuyen:any;
  nguoiSua:any; 
  nguoiThem:any;
  
  @Input() nVien:any;

  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.maNhanVien = this.nVien.idnv;
    this.tenNhanVien = this.nVien.hoTen;
    this.diaChi = this.nVien.diaChi;
    this.gioiTinh = this.nVien.gioiTinh;
    this.ngaySinh = this.nVien.ngaySinh;
    this.soDienThoai = this.nVien.sdt;
    this.cmnd = this.nVien.cmnd;
    this.IDPhongBan = this.nVien.idPhongBan;
    this.idNhomQuyen = this.nVien.idNhomQuyen;
    this.nguoiThem = this.nVien.nguoiThem;
    this.nguoiSua=this.nVien.nguoiSua;

  }
  luuNV(){
    if (this.maNhanVien==0) this.themNhanVien()
    else this.suaNhanVien()
  }
  themNhanVien(){
    var val = {
      HoTen:this.tenNhanVien,
      DiaChi:this.diaChi,   
      GioiTinh:this.gioiTinh,
      NgaySinh:this.ngaySinh,
      SDT:this.soDienThoai,
      CMND:this.cmnd,
      IDPhongBan:this.IDPhongBan,
      IDNhomQuyen:this.idNhomQuyen,
      NguoiThem:this.nguoiThem,
      NguoiSua:" "
    };
    console.log(val)
   this.service.themNhanVien(val).pipe(first()).subscribe(res=>{
    console.log(res); 
   location.reload();
   })
  }
  suaNhanVien(){
    var val = {
      IDNV:this.maNhanVien,
      HoTen:this.tenNhanVien,
      DiaChi:this.diaChi,   
      GioiTinh:this.gioiTinh,
      NgaySinh:this.ngaySinh,
      SDT:this.soDienThoai,
      CMND:this.cmnd,
      IDPhongBan:this.IDPhongBan,
      IDNhomQuyen:this.idNhomQuyen,
      NguoiThem:" ",
      nguoiSua:this.nguoiSua
    };
    this.service.suaNhanVien(val).pipe(first()).subscribe(res=>{
    console.log(res);
    location.reload();
    })
    }
}
