import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemSuaPBanComponent } from './them-sua-p-ban.component';

describe('ThemSuaPBanComponent', () => {
  let component: ThemSuaPBanComponent;
  let fixture: ComponentFixture<ThemSuaPBanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThemSuaPBanComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ThemSuaPBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
