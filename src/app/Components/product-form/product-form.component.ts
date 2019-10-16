import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
  productForm: FormGroup;
  constructor(public fb: FormBuilder) {
    this.productForm = this.fb.group({
      name: ['', [Validators.required]],
      price: ['', [Validators.required]]
    });
  }

  submitForm() {
    console.log(this.productForm.value);
  }
  ngOnInit() {
  }

}
