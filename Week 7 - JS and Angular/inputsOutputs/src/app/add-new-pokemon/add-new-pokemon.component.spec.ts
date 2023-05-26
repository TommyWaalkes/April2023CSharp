import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNewPokemonComponent } from './add-new-pokemon.component';

describe('AddNewPokemonComponent', () => {
  let component: AddNewPokemonComponent;
  let fixture: ComponentFixture<AddNewPokemonComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddNewPokemonComponent]
    });
    fixture = TestBed.createComponent(AddNewPokemonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
