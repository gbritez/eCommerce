import { Injectable } from '@angular/core';
import { Product } from '../Models/Product';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ProductsService {

    constructor(private httpClient: HttpClient) {
    }

    // getProducts(): Observable<Array<Product>> {
    //     return this.httpClient.get<Array<Product>>('https://localhost:44328/products/get');
    // }

    getProductByCategory(filter: string): Observable<Array<Product>> {

        return this.httpClient.get<Array<Product>>('https://localhost:44328/products/GetByCategory?filter=' + filter);
    }

}
