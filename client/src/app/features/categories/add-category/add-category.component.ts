import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SharedService } from 'app/core/shared.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {

  addCategoryForm:FormGroup = new FormGroup({});

  constructor(private formBuilder: FormBuilder,private service: SharedService,private toastr:ToastrService,public route:Router) { }

  ngOnInit(): void {
    this.addCategoryForm = this.formBuilder.group({
      'name': new FormControl('',[Validators.required]),
    })
  }
  addCategory()
  {
    this.service.addCategory(this.addCategoryForm.value).subscribe(data=>{
    }),err=>{
      this.toastr.error(err.error);
      console.log("Unable to create category for recipe");
    }
    setTimeout(() => {
      this.route.navigate(['/categories']);
    }, 2000);
    this.addCategoryForm.reset();
    this.toastr.success("Category succesfully added");
  }
}
