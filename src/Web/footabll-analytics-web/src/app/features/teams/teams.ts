import { Component } from '@angular/core';

@Component({
  selector: 'app-teams',
  imports: [],
  templateUrl: './teams.html',
  styleUrl: './teams.scss',
})
export class Teams {
  teams = [
    { id: 1, name: "Chelsea" },
    { id: 2, name: "Liverpool" },
    { id: 3, name: "Arsenal" },
    { id: 4, name: "Newcastle" }
  ]
}
