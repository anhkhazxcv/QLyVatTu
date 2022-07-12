import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-ds-p-ban',
  templateUrl: './ds-p-ban.component.html',
  styleUrls: ['./ds-p-ban.component.css']
})
export class DsPBanComponent implements OnInit {

  constructor(private service:SharedService) { }
  tieuDe:any
  pBan:any=[]
  dangThemSua:boolean=false
  DSPhongBan:any=[]

  ngOnInit(): void {
    this.tailaiDSPhongBan();
  }
  tailaiDSPhongBan(){
    this.service.layDSPhongBan().subscribe(data =>{
    this.DSPhongBan=data;
    })
  }

  themPhongBan(){
    this.dangThemSua=true;
    this.pBan.idPhongBan=0;
    this.tieuDe="Thêm Phòng Ban"
  }

  chiTietPhongBan(pBan:any){
    this.pBan=pBan;
    this.dangThemSua=true;
    this.tieuDe="Sửa Phòng Ban"
  }
  xoaPhongBan(pBan:any){
   console.log(pBan.idPhongBan)
    this.service.XoaPhongBan(pBan.idPhongBan).subscribe(data=>{
      this.tailaiDSPhongBan()
    })}

  dong(){
    this.dangThemSua=false;
    location.reload()
    //this.tailaiDSPhongBan()
  }


}
