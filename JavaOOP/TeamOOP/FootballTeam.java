package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class FootballTeam extends Team {
    public FootballTeam(String name , int players){
        this.name = name;
        this.NumberPlayer =  players;

    }


    @Override
    public String toString()
    {
        return "Name of the Football team: " +getName() + "   Number of players: " + getNumberPlayer() ;
    }
}
