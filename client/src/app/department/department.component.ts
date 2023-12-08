import { Component, OnInit } from "@angular/core";
import { Department } from "../shared/Department";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Component({
  selector: 'department-comp',
  templateUrl: './department.component.html'
})

export class DepartmentComponent implements OnInit {
  departmentList: Department[];

  constructor(private http: HttpClient) {

  }
  ngOnInit(): void {
    this.http.get<[]>("/api/departments").pipe(map(data => {
      this.departmentList = data;
      return;
    }));
    }
}
