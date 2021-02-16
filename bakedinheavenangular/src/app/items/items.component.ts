import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css'],
  providers: [DatePipe]
})
export class ItemsComponent {
//items :any= {};
  items:any;
  specialItem:any;
  todaydate :any=new Date()
  tomorrow :any =new Date();
  
  
  
  constructor(public apiService: ApiService,private datePipe: DatePipe) {
    this.apiService.getItems().subscribe((res:any) =>{
      this.items = res
      console.log(this.items)
      this.tomorrow.setDate(this.todaydate.getDate() + 1);
      
    })
  }
 
  
    
 
  checkdate(item:any)
  {
    item.availableDate = this.datePipe.transform(item.availableDate, 'yyyy-MM-dd');
    this.todaydate = this.datePipe.transform(this.todaydate, 'yyyy-MM-dd');
    this.tomorrow = this.datePipe.transform(this.tomorrow, 'yyyy-MM-dd');
    
      
    if((item.availableDate==this.todaydate)||(item.availableDate==this.tomorrow))
    {
      return true;
    }
    else{
      return false;
    }
  }
   
    //ngOnInit() :void{
      
    //}

}
