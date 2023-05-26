import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ToDoListSingleComponent } from './to-do-list-single.component';

describe('ToDoListSingleComponent', () => {
  let component: ToDoListSingleComponent;
  let fixture: ComponentFixture<ToDoListSingleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ToDoListSingleComponent]
    });
    fixture = TestBed.createComponent(ToDoListSingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
