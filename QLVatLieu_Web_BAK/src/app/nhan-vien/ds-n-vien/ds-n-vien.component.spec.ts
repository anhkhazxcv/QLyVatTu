import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DsNVienComponent } from './ds-n-vien.component';

describe('DsNVienComponent', () => {
  let component: DsNVienComponent;
  let fixture: ComponentFixture<DsNVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DsNVienComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DsNVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
