import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NhomQuyenChucNangComponent } from './nhom-quyen-chuc-nang.component';

describe('NhomQuyenChucNangComponent', () => {
  let component: NhomQuyenChucNangComponent;
  let fixture: ComponentFixture<NhomQuyenChucNangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NhomQuyenChucNangComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NhomQuyenChucNangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
