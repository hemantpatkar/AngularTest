import { HttpClient } from "@angular/common/http";
import { catchError, of } from "rxjs";
import { productdetails } from "../models/productdetails";
import { Injectable } from "@angular/core";
import { debug } from "console";

@Injectable({
    providedIn:"root"
  })

export class productservice {
    constructor(
        private http: HttpClient ) {
        
    }

     getproductdetails(productid: number)
    {
        
       return   this.http.get<productdetails>("https://localhost:7246/api/product?id="+productid).pipe(catchError(error=> {

            if(error===404){
                return of(null);
            }
            else
            {
                return of(error);
            }
        }))
 
    }
}