import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/app/Models/Product';
import { ProductsService } from 'src/app/Services/product.services';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: Product[];

  constructor(private productsService: ProductsService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit() {
    // this.products = [
    //   { id: 1, name: 'Remera', price: 12, category: 1, description: 'test', size: 2 },
    //   { id: 2, name: 'Pantalon', price: 20, category: 1, description: 'test', size: 1 },
    //   { id: 3, name: 'Buzo', price: 16, category: 1, description: 'test', size: 1 }
    // ];
    const filter = this.route.snapshot.paramMap.get('filter');
    this.productsService.getProductByCategory(filter).subscribe((data) => {
      this.products = data;
    }
    );
  }

}
