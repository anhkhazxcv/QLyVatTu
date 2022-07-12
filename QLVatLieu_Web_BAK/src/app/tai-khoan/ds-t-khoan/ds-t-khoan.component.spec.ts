import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DsTKhoanComponent } from './ds-t-khoan.component';

describe('DsTKhoanComponent', () => {
  let component: DsTKhoanComponent;
  let fixture: ComponentFixture<DsTKhoanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DsTKhoanComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DsTKhoanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
