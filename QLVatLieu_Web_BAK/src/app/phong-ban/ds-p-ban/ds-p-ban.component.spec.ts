import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DsPBanComponent } from './ds-p-ban.component';

describe('DsPBanComponent', () => {
  let component: DsPBanComponent;
  let fixture: ComponentFixture<DsPBanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DsPBanComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DsPBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
