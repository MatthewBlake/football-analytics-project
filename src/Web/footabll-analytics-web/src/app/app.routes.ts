import { Routes } from '@angular/router';
import { Home } from './features/home/home';
import { Teams } from './features/teams/teams';
import { Fixtures } from './features/fixtures/fixtures';
import { LeagueTable } from './features/league-table/league-table'

export const routes: Routes = [
  {
    path: '',
    component: Home
  },
  {
    path: 'teams',
    component: Teams
  },
  {
    path: 'fixtures',
    component: Fixtures
  },
  {
    path: 'leaugetable',
    component: LeagueTable
  }
];
