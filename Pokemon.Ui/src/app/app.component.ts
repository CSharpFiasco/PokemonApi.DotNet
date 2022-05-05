import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ODataResponse } from '../models/odata-response';
import { Pokemon } from '../models/pokemon';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public pokemonList?: Pokemon[];

  constructor(http: HttpClient) {
    http.get<ODataResponse<Pokemon>>('https://localhost:44357/v1/pokemon').subscribe(result => {
      this.pokemonList = result.value;
    }, error => console.error(error));
  }

  title = 'Pokemon.Ui';
}
