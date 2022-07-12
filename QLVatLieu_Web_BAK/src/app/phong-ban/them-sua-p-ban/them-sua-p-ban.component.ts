import { NgStyle } from '@angular/common';
import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { first } from 'rxjs';
@Component({
  selector: 'app-them-sua-p-ban',
  templateUrl: './them-sua-p-ban.component.html',
  styleUrls: ['./them-sua-p-ban.component.css']
})
export class ThemSuaPBanComponent implements OnInit {
  MaPhongBan:any
  TenPhongBan:any
  NguoiThem:any
  NguoiSua:any
  @Input() pBan:any;
  constructor(private service:SharedService) { }
    ngOnInit(): void {
      this.MaPhongBan=this.pBan.idPhongBan
      this.TenPhongBan=this.pBan.tenPhongBan
      this.NguoiThem=this.pBan.nguoiThem
      this.NguoiSua=this.pBan.nguoiSua
  }
  luuNV(){
    
    if (this.MaPhongBan==0) {
        
      this.themPhongBan()
      
      
    }
    else {
      
      this.suaPhongBan()
      
    }
  }
  themPhongBan(){
    var val = {
      tenPhongBan:this.TenPhongBan,  
      nguoiThem:this.NguoiThem,
      nguoiSua:" "
    };
    console.log(val)
   this.service.ThemPhongBan(val).pipe(first()).subscribe(res=>{
    console.log(res); 
   location.reload();
   })
  }
  suaPhongBan(){
    var val = {
      idPhongBan:this.MaPhongBan,
      tenPhongBan:this.TenPhongBan, 
      nguoiThem:" ",
      nguoiSua:this.NguoiSua
    };
    this.service.suaPhongBan(val).pipe(first()).subscribe(res=>{
    console.log(res);
    location.reload();
    })
    }
}
