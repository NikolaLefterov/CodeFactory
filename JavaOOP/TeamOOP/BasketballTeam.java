package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class BasketballTeam extends Team {
    public BasketballTeam(String name , int players){
        this.name = name;
        this.NumberPlayer =  players;

    }

    @Override
    public String toString(){
        return "Name of the basketball team: " +getName() + "   Number of players: " + getNumberPlayer() ;
    }
}
