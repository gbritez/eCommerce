import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopBarComponent } from './Components/top-bar/top-bar.component';
import { BottomBarComponent } from './Components/bottom-bar/bottom-bar.component';
import { ProductCardComponent } from './Components/product-card/product-card.component';
import { CategoryComponent } from './Components/category/category.component';
import { ProductComponent } from './Components/product/product.component';
import { ProductDetailComponent } from './Components/product-detail/product-detail.component';
import { BoxComponent } from './Components/box/box.component';

@NgModule({
  declarations: [
    AppComponent,
    BottomBarComponent,
    ProductCardComponent,
    TopBarComponent,
    CategoryComponent,
    ProductComponent,
    ProductDetailComponent,
    BoxComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
