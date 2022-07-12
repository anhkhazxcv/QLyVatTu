import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemSuaNVienComponent } from './them-sua-n-vien.component';

describe('ThemSuaNVienComponent', () => {
  let component: ThemSuaNVienComponent;
  let fixture: ComponentFixture<ThemSuaNVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThemSuaNVienComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ThemSuaNVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
