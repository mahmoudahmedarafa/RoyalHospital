import { Component, OnInit } from "@angular/core";
import { News } from "../shared/News";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Component({
  selector: 'news-list',
  templateUrl: './newslist.component.html'
})
export class NewsListComponent {
  newsList: News[];

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.http.get<[]>("/api/news").pipe(map(data => {
      this.newsList = data;
      return;
    }));
  }
}
