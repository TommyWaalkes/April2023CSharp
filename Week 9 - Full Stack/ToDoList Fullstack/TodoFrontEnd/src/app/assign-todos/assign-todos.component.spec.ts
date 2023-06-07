import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignTodosComponent } from './assign-todos.component';

describe('AssignTodosComponent', () => {
  let component: AssignTodosComponent;
  let fixture: ComponentFixture<AssignTodosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AssignTodosComponent]
    });
    fixture = TestBed.createComponent(AssignTodosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
