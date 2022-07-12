import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemSuaTKhoanComponent } from './them-sua-t-khoan.component';

describe('ThemSuaTKhoanComponent', () => {
  let component: ThemSuaTKhoanComponent;
  let fixture: ComponentFixture<ThemSuaTKhoanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThemSuaTKhoanComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ThemSuaTKhoanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
