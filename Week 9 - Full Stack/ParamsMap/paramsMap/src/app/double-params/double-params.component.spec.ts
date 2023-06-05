import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DoubleParamsComponent } from './double-params.component';

describe('DoubleParamsComponent', () => {
  let component: DoubleParamsComponent;
  let fixture: ComponentFixture<DoubleParamsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DoubleParamsComponent]
    });
    fixture = TestBed.createComponent(DoubleParamsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
