import { HttpClient } from '@angular/common/http';
import { Team } from './team';
import { Injectable } from '@angular/core';
import { CreateTeam } from './create-team';

@Injectable({
  providedIn: 'root'
})
export class TeamsService {
  constructor(private http: HttpClient) { }

  getTeams() {
    return this.http.get<Team[]>('http://localhost:5000/api/v1/team');
  }

  createTeam(team: CreateTeam) {
    return this.http.post<Team>('http://localhost:5000/api/v1/team', team);
  }
}
