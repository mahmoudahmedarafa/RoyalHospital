import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Department } from "../shared/Department";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Component({
  selector: 'department-details',
  templateUrl: './departmentdetails.component.html'
})

export class DepartmentDetailsComponent implements OnInit {
  departmentSelector: "";
  selectedDepartment: Department;
  allDepartments: Department[];

  constructor(private route: ActivatedRoute, private http: HttpClient) {

  }

  ngOnInit(): void {
    this.departmentSelector = this.route.snapshot.params['selector'];

    this.http.get<Department>("/api/departments/{departmentSelector}").pipe(map(data => {
      this.selectedDepartment = data;
      return;
    }));

    this.http.get<[]>("/api/departments").pipe(map(data => {
      this.allDepartments = data;
      return;
    }));
  }
}
