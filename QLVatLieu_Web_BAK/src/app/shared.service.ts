import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIurl = "https://localhost:7129/api";
  constructor(private http:HttpClient) { }
  layDSNhanVien():Observable<any[]>{
    return this.http.get<any>(this.APIurl+'/NhanVien')
  }
  themNhanVien(val:any){
    return this.http.post(this.APIurl+'/NhanVien',val)
  }
  suaNhanVien(val:any){
    return this.http.put(this.APIurl+'/NhanVien',val)
  }
  XoaNhanVien(val:any){
    return this.http.delete(this.APIurl+'/NhanVien?id=' + val)
  }

  layDSTaiKhoan():Observable<any[]>{
    return this.http.get<any>(this.APIurl+'/TaiKhoan')
  }
  ThemTaiKhoan(val:any){
    return this.http.post(this.APIurl+'/TaiKhoan',val)
  }
  suaTaiKhoan(val:any){
    return this.http.put(this.APIurl+'/TaiKhoan',val)
  }
  XoaTaiKhoan(val:any){
    return this.http.delete(this.APIurl+'/TaiKhoan?id=' + val)
  }
  
  dangNhap(val:any){
    return this.http.post(this.APIurl+'/DangNhap',val)
  }

  layDSPhongBan():Observable<any[]>{
    return this.http.get<any>(this.APIurl+'/PhongBan')
  }
  ThemPhongBan(val:any){
    return this.http.post(this.APIurl+'/PhongBan',val)
  }
  suaPhongBan(val:any){
    return this.http.put(this.APIurl+'/PhongBan',val)
  }
  XoaPhongBan(val:any){
    return this.http.delete(this.APIurl+'/PhongBan?id=' + val)
  }

  layDSNhomQuyen_TaiKhoan():Observable<any[]>{
    return this.http.get<any>(this.APIurl+'/NhomQuyen_TaiKhoan')
}

layDSNhomQuyen_ChucNang():Observable<any[]>{
  return this.http.get<any>(this.APIurl+'/NhomQuyen_ChucNang')
}
}
