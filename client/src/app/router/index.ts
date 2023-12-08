import { RouterModule } from "@angular/router";
import { DepartmentComponent } from "../department/department.component";
import { DepartmentDetailsComponent } from "../department/departmentdetails.component";
//import { AuthActivator } from "../services/authActivator.service";

const routes = [
  //{ path: "checkout", component: Checkout, canActivate: [AuthActivator] },
  { path: "departments", component: DepartmentComponent },
  {path: 'departments/:selector', component: DepartmentDetailsComponent},
  { path: "**", redirectTo: "/" }
];

const router = RouterModule.forRoot(routes);

export default router;
