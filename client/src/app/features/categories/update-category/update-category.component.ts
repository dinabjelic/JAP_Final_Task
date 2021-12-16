import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgControlStatus, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { UpdateCategoryRequest } from 'app/core/requests/UpdateCategoryRequest';
import { CategoryService } from 'app/core/services/category.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {

  updateCategoryForm: FormGroup = new FormGroup({});
  updateCategoryrequest: UpdateCategoryRequest;

  constructor(private formBuilder: FormBuilder, private service: CategoryService, private router: ActivatedRoute,
    private toastr:ToastrService,public route:Router) {

    this.updateCategoryForm = this.formBuilder.group({
      name: new FormControl(''),
      id: new FormControl('')
    })
  }

  ngOnInit(): void {
    this.service.getCurrentCategoryData(this.router.snapshot.params.id).subscribe((data) => {
      
      this.updateCategoryForm = new FormGroup({
        name: new FormControl(data['name']),
        id: new FormControl(this.router.snapshot.params.id)
      })
    })
  }

  updateCategory() {
    this.service.updateCategory(this.updateCategoryForm.value).subscribe(data => {
    }), err => {
      this.toastr.error(err.error);
      console.log("Unable to update category for recipe");
    }
    this.updateCategoryForm.reset();
    setTimeout(() => {
      this.route.navigate(['/categories']);
    }, 2000);
    this.toastr.success("Category succesfully updated");
  }

}
