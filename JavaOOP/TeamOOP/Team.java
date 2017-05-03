package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class Team {
    protected String name;
    protected int NumberPlayer;
    public Team(){
        name = "no name";
        NumberPlayer = 0;
    }
    public void setName(String name) {
        this.name = name;
    }

    public void setNumberPlayer(int numberPlayer)
    {
        this.NumberPlayer = numberPlayer;
    }

    public int getNumberPlayer() {

        return NumberPlayer;
    }

    public String getName() {

        return name;
    }
}
