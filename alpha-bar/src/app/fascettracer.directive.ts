import { Directive, ElementRef, HostListener, Input, OnInit, Renderer2, ViewChild } from '@angular/core';
import { Console } from 'node:console';

@Directive({
    selector:'[fascettracer]',
    standalone:true,
})

export class fascettracer{
    @Input() text?: string;
    constructor(private ref: ElementRef, private renderer:Renderer2 ){     
         
    }
    ngOnInit(){
        
    }
    ngOnChanges() {
        debugger; 
        this.ref.nativeElement.textContent = this.text;
      }
    
      @ViewChild('abcd') 
      private abcd = {} as ElementRef;
    @HostListener('click') onClick($event:Event) {
        debugger; 
          console.log(this.text);
            
          const li = this.renderer.createElement('li');
          const text = this.renderer.createText('Click here to add li');
          this.renderer.appendChild(li, text);
          this.renderer.appendChild(this.abcd.nativeElement, li);

        let newele = this.renderer.createElement('<br>')
         
        this.renderer.appendChild(this.ref.nativeElement, newele)
        let newtext = this.renderer.createElement('<br>')
         
        this.renderer.appendChild(this.ref.nativeElement, newtext)
      }
     
       
}