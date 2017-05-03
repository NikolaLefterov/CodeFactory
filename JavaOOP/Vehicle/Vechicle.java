package com.company;

/**
 * Created by Nikola on 3/29/2017.
 */
abstract class Vechicle {
    protected int speed ;
    Vechicle(){
        speed =0;
    }
     public  void setSpeed(int speed1){
            speed = speed1;
    }
    public int getSpeed(){
         return speed;
    }
    abstract void whatIAM ();
    abstract String getMarka();
    abstract  String getModel();


}

