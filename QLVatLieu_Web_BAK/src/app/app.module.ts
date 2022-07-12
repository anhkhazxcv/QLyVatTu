import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NhanVienComponent } from './nhan-vien/nhan-vien.component';
import { DsNVienComponent } from './nhan-vien/ds-n-vien/ds-n-vien.component';
import { ThemSuaNVienComponent } from './nhan-vien/them-sua-n-vien/them-sua-n-vien.component';

import { SharedService } from './shared.service';
import { HttpClientModule} from '@angular/common/http'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { TaiKhoanComponent } from './tai-khoan/tai-khoan.component';
import { DsTKhoanComponent } from './tai-khoan/ds-t-khoan/ds-t-khoan.component';
import { ThemSuaTKhoanComponent } from './tai-khoan/them-sua-t-khoan/them-sua-t-khoan.component';
import { PhongBanComponent } from './phong-ban/phong-ban.component';
import { DsPBanComponent } from './phong-ban/ds-p-ban/ds-p-ban.component';
import { ThemSuaPBanComponent } from './phong-ban/them-sua-p-ban/them-sua-p-ban.component';
import { NhomQuyenChucNangComponent } from './nhom-quyen-chuc-nang/nhom-quyen-chuc-nang.component';
@NgModule({
  declarations: [
    AppComponent,
    NhanVienComponent,
    DsNVienComponent,
    ThemSuaNVienComponent,
    LoginComponent,
    TaiKhoanComponent,
    DsTKhoanComponent,
    ThemSuaTKhoanComponent,
    PhongBanComponent,
    DsPBanComponent,
    ThemSuaPBanComponent,
    NhomQuyenChucNangComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
