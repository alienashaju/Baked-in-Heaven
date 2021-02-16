import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';
import{ActivatedRoute, Router} from '@angular/router';
import { FormGroup,FormBuilder, Validators } from '@angular/forms';



@Component({
  selector: 'app-edit-item',
  templateUrl: './edit-item.component.html',
  styleUrls: ['./edit-item.component.css']
})
export class EditItemComponent  {
  panelTitle:any
  items: any = {}
  submitted = false;
  itemid:any
  addform!: FormGroup ;
   
  
  
  constructor(public apiService: ApiService, private route:ActivatedRoute,public router:Router,private fb:FormBuilder) {
   
  }
  
  ngOnInit() {
    this.route.paramMap.subscribe(parameterMap => {
      const id = parameterMap.get('id');
      this.getItem(id);
      this.itemid=id;
      });
      this.addform = this.fb.group({
        itemName:['',Validators.required],
        price:['',Validators.required],
        quantity:['',Validators.required],
        weight:['',Validators.required],
        kcal:['',Validators.required],
        isveg:['',Validators.required],
        isspecial:['',Validators.required],
        date:['',Validators.required],
        image:['',Validators.required],

      });
  }
  
  private getItem(id:any)
  {
    if(id !=0){
      this.items= this.apiService.getItem(id).subscribe(
        (item) => { this.items = item;
          console.log(this.items)
        });
      this.panelTitle = 'Edit Item';
    }
    else{
      this.panelTitle = 'Add Item';
      this.items ={
        itemName :"",
        price : "",
        quantity :"",
        weightInGrams:"",
        availableDate:"",
        isVeg :"",
        isSpecial :""
        
      }
      
    }
    
  }
  addClick(items:any){
    this.submitted = true;
    if (this.addform.invalid) {
      return;
      }
   
      this.apiService.postItem(items);
      this.router.navigate(['/admin'])
        this.refreshItems();
    }


  editClick(items:any){
    this.submitted = true;
    if (this.addform.invalid) {
      return;
      }
    if(confirm('Are you sure??')){
      this.apiService.putItem(items);
      this.router.navigate(['/admin'])
        this.refreshItems();  

  }
}

  refreshItems(){
    this.apiService.getItems().subscribe(data=>{
     this.items=data;
    });
    }
  }




