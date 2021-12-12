import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgControlStatus } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { UpdateCategoryRequest } from 'app/core/requests/UpdateCategoryRequest';
import { SharedService } from 'app/core/shared.service';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {

  updateCategoryForm: FormGroup = new FormGroup({});
  updateCategoryrequest: UpdateCategoryRequest;

  constructor(private formBuilder: FormBuilder, private service: SharedService, private router: ActivatedRoute) {

    this.updateCategoryForm = this.formBuilder.group({
      name: new FormControl(''),
      id: new FormControl('')
    })
  }

  ngOnInit(): void {
    this.service.getCurrentCategoryData(this.router.snapshot.params.id).subscribe((data) => {
      
      this.updateCategoryForm = new FormGroup({
        name: new FormControl(data[0].name),
        id: new FormControl(this.router.snapshot.params.id)
      })
    })
  }

  updateCategory() {
    this.service.updateCategory(this.updateCategoryForm.value).subscribe(data => {
    }), err => {
      console.log("Unable to update category for recipe");
    }
    this.updateCategoryForm.reset();
  }

}
