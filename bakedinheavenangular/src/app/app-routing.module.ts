import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {ItemsComponent} from './items/items.component';
import {HomeComponent} from './home/home.component';
import {AdminComponent} from './admin/admin.component';
import {EditItemComponent} from './edit-item/edit-item.component';
import {LoginComponent} from './login/login.component';

export const routes: Routes = [
  {path: '', component: HomeComponent},
  { path: 'home', component: HomeComponent },
  { path: 'items', component: ItemsComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'edit-item/:id', component: EditItemComponent },
  { path: 'login', component: LoginComponent },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
