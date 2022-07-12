import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
@Component({
  selector: 'app-nhom-quyen-chuc-nang',
  templateUrl: './nhom-quyen-chuc-nang.component.html',
  styleUrls: ['./nhom-quyen-chuc-nang.component.css']
})
export class NhomQuyenChucNangComponent implements OnInit {

  constructor(private service:SharedService) { }

 DSNhomQuyen_TaiKhoan :any=[]

  ngOnInit(): void {
    this.tailaiDSPhongBan();
  }
  tailaiDSPhongBan(){
    this.service.layDSNhomQuyen_ChucNang().subscribe(data =>{
      console.log(data)
    this.DSNhomQuyen_TaiKhoan=data;
    })
  }
}
