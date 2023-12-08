import { Component, OnInit } from "@angular/core";
import { Doctor } from "../shared/Doctor";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Component({
  selector: 'doctor-list',
  templateUrl: './doctorlist.component.html'
})
export class DoctorListComponent implements OnInit {
  doctorList: Doctor[];

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.http.get<[]>("/api/doctors").pipe(map(data => {
      this.doctorList = data;
      return;
    }));
  }
}
