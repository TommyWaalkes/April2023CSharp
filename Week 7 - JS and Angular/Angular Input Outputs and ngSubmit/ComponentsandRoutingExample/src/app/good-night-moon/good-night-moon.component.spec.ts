import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodNightMoonComponent } from './good-night-moon.component';

describe('GoodNightMoonComponent', () => {
  let component: GoodNightMoonComponent;
  let fixture: ComponentFixture<GoodNightMoonComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GoodNightMoonComponent]
    });
    fixture = TestBed.createComponent(GoodNightMoonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
