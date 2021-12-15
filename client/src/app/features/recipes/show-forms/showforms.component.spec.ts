import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowformsComponent } from './showforms.component';

describe('ShowformsComponent', () => {
  let component: ShowformsComponent;
  let fixture: ComponentFixture<ShowformsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowformsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowformsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
