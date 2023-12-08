import { Component, OnInit } from "@angular/core";
import { Clinic } from "../shared/Clinic";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Component({
  selector: 'clinic-list',
  templateUrl: './cliniclist.component.html'
})
export class ClinicListComponent implements OnInit {
  clinicList: Clinic[];

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.http.get<[]>("/api/clinics").pipe(map(data => {
      this.clinicList = data;
      return;
    }));
  }
}
