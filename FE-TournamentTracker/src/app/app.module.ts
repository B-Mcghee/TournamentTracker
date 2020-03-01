import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './header/header.component';
import { TournamentComponent } from './tournament/tournament.component';
import { AddTeamComponent } from './tournament/add-team/add-team.component';
import { PrizeComponent } from './tournament/prize/prize.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    TournamentComponent,
    AddTeamComponent,
    PrizeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
