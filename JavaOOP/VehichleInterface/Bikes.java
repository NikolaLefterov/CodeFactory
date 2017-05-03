package com.company;

/**
 * Created by Nikola on 3/29/2017.
 */
public class Bikes implements Vechicle,Sorableby  {
    String marka;
    String model;
    int speed;
    int price;
    public Bikes(String marka1,String Model1, int Speed1,int price){
        marka = marka1;
        model = Model1;
        speed = Speed1;
        this.price= price;
    }


    public void setPrice(int price) {
        this.price = price;
    }


    public void setMarka(String marka) {
        this.marka = marka;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public void setSpeed(int speed) {
        this.speed = speed;
    }

    @Override
    public int compareTo( int X, Vechicle other) {
        if(X == 0){
            if (this.maxSpeed() > other.maxSpeed())
                return 1;
            else if (this.maxSpeed() < other.maxSpeed())
                return -1;


        }
        if(X==3){
            if (this.Price() > other.Price())
                return 1;
            else if (this.Price() < other.Price())
                return -1;
        }
        if(X==1){
            if(this.getMarka().equals(other.getMarka())){
                return 1;
            }
            else return -1;
        }
        if(X==2){
            if(this.getMarka().equals(other.getMarka())){
                return 1;
            }
            else return -1;
        }
        return 0;
    }

    @Override
    public int Price() {
       return price;
    }

    @Override
    public int maxSpeed() {
        return speed;
    }
    @Override
    public String getMarka() {
        return marka;
    }
    @Override
    public String getModel() {
        return model;
    }
}
