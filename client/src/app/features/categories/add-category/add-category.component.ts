import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SharedService } from 'app/core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {

  addCategoryForm:FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder,private service: SharedService,private toastr:ToastrService) { }

  ngOnInit(): void {
    this.addCategoryForm = this.formBuilder.group({
      'name': new FormControl(''),
    })
  }
  addCategory()
  {
    this.service.addCategory(this.addCategoryForm.value).subscribe(data=>{
    }),err=>{
      this.toastr.error(err.error);
      console.log("Unable to create category for recipe");
    }
    this.addCategoryForm.reset();
    this.toastr.success("Category succesfully added");
  }
}
