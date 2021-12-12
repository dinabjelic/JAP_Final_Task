import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowrecipedetailsComponent } from './showrecipedetails.component';

describe('ShowrecipedetailsComponent', () => {
  let component: ShowrecipedetailsComponent;
  let fixture: ComponentFixture<ShowrecipedetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowrecipedetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowrecipedetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
