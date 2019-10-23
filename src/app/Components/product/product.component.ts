import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/Models/Product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: Product[];
  constructor() { }

  ngOnInit() {
    this.products = [
      { id: 1, name: 'Remera', price: 12, category: 1, description: 'test', size: 2 },
      { id: 2, name: 'Pantalon', price: 20, category: 1, description: 'test', size: 1 },
      { id: 3, name: 'Buzo', price: 16, category: 1, description: 'test', size: 1 }
    ];
  }

}
