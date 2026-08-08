import { Component, signal } from '@angular/core';
import { Team } from './team';
import { TeamsService } from './teams.service';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-teams',
  imports: [ReactiveFormsModule],
  templateUrl: './teams.html',
  styleUrl: './teams.scss',
})

export class Teams {
  constructor(private teamsService: TeamsService) { }

  teamForm = new FormGroup({
    name: new FormControl(''),
    colour: new FormControl('')
  });

  teams = signal<Team[]>([]);

  ngOnInit() {
    this.teamsService.getTeams().subscribe({
      next: (teams) => {
        console.log(teams);
        this.teams.set(teams);
      },
      error: (error) => {
        console.error(error);
      }
    })
  }

  selectedTeam: Team | null = null;

  selectTeam(team: Team) {
    this.selectedTeam = team;
  }
}
