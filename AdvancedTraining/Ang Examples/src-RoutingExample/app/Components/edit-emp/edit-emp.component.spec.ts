import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditEmpComponent } from './edit-emp.component';

describe('EditEmpComponent', () => {
  let component: EditEmpComponent;
  let fixture: ComponentFixture<EditEmpComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EditEmpComponent]
    });
    fixture = TestBed.createComponent(EditEmpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
