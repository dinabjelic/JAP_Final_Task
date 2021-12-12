import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecipesForCategoryComponent } from './recipes-for-category.component';

describe('RecipesForCategoryComponent', () => {
  let component: RecipesForCategoryComponent;
  let fixture: ComponentFixture<RecipesForCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecipesForCategoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecipesForCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
