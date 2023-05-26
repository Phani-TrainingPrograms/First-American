import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpMgrComponent } from './emp-mgr.component';

describe('EmpMgrComponent', () => {
  let component: EmpMgrComponent;
  let fixture: ComponentFixture<EmpMgrComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmpMgrComponent]
    });
    fixture = TestBed.createComponent(EmpMgrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
