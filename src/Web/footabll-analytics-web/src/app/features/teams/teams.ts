import { Component, signal } from '@angular/core';
import { Team } from './team';
import { TeamsService } from './teams.service';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { CreateTeam } from './create-team';

@Component({
  selector: 'app-teams',
  imports: [ReactiveFormsModule],
  templateUrl: './teams.html',
  styleUrl: './teams.scss',
})

export class Teams {
  constructor(private teamsService: TeamsService) { }

  teamForm = new FormGroup({
    name: new FormControl('', { nonNullable: true }),
    colour: new FormControl('', {nonNullable: true })
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

  onSubmit() {
    this.teamsService.createTeam(this.teamForm.getRawValue()).subscribe({
      next: (createdTeam) => {
        this.teams.update(teams => [...teams, createdTeam]);
        this.teamForm.reset();
      },
      error: (error) => console.error(error)

    });
  }
}
