import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiComponentListComponent } from './multi-component-list.component';

describe('MultiComponentListComponent', () => {
  let component: MultiComponentListComponent;
  let fixture: ComponentFixture<MultiComponentListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MultiComponentListComponent]
    });
    fixture = TestBed.createComponent(MultiComponentListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
