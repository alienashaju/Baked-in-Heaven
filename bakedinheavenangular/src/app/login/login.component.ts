import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';
import{Router} from '@angular/router';
import { FormGroup,FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginform!: FormGroup ;
  submitted= false;
  
  users :any=[];
  constructor(public apiService:ApiService,public router:Router,private fb:FormBuilder) { 
    this.apiService.getUsers().subscribe((res:any) => {
      this.users = res
      console.log(res);
      
    })
  }

  ngOnInit(): void {
    this.loginform = this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required]
    });
  }
 
  
  myusername :any;
  mypassword:any;
  login(){
    this.submitted = true;
    
    this.users.forEach((element:any) => {
      if((this.myusername == element.username)&&(this.mypassword== element.password))
      {
        if(element.isAdmin==true)
        {
          console.log(this.myusername)
          this.router.navigate(['/admin']);
          
        }
        else
        {
          this.router.navigate(['/items']);
        }
      }
     
    });
    
  
  
    }
 
    
  }
