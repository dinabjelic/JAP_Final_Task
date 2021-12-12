import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowcategoryrecipesComponent } from './showcategoryrecipes.component';

describe('ShowcategoryrecipesComponent', () => {
  let component: ShowcategoryrecipesComponent;
  let fixture: ComponentFixture<ShowcategoryrecipesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowcategoryrecipesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowcategoryrecipesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
