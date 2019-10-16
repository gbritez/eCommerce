import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoryComponent } from './Components/category/category.component';
import { ProductDetailComponent } from './Components/product-detail/product-detail.component';
import { ProductFormComponent } from './Components/product-form/product-form.component';


const routes: Routes = [
  { path: 'category', component: CategoryComponent },
  { path: 'product/:id', component: ProductDetailComponent },
  { path: 'newProduct', component: ProductFormComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
