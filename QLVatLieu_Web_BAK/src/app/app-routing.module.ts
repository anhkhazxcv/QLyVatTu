import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NhanVienComponent } from './nhan-vien/nhan-vien.component';
import { TaiKhoanComponent } from './tai-khoan/tai-khoan.component';
import { LoginComponent } from './login/login.component';
import { PhongBanComponent } from './phong-ban/phong-ban.component';
import { NhomQuyenChucNangComponent } from './nhom-quyen-chuc-nang/nhom-quyen-chuc-nang.component';
const routes: Routes = [
  {path:'nhanVien', component:NhanVienComponent},
  {path:'login', component:LoginComponent},
  {path:'taiKhoan', component:TaiKhoanComponent},
  {path:'phongBan',component:PhongBanComponent},
  {path:'nhomQuyenChucNang',component:NhomQuyenChucNangComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
