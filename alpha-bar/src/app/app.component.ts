import { Component, Injectable, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { productservice } from './services/product.service';
import { productdetails } from './models/productdetails';
import { fascettracer } from './fascettracer.directive';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,fascettracer],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

 
export class AppComponent implements OnInit{


   result : string="Invalid Prod TP";
   drinks : string="Cannot Mix It";
  constructor(
    private productservice: productservice ) {
  }

   ngOnInit()
   {
     
   } 

   
onChange(str: String) {
    this.productservice.getproductdetails(Number(str)).subscribe(data=>{
      if(data===null)
        {
          this.result = "Invalid Prod TP";
          this.drinks = "Cannot Mix It";
        }
        else
        {
          this.drinks = "Ready To Mix";
          this.result = data.product_Name
        }
   
  console.log(data);
  });
}
 
OnClick($event: MouseEvent) {
  this.drinks = "Milk Shake";
  }


}
