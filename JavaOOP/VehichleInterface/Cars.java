package com.company;

/**
 * Created by Nikola on 3/29/2017.
 */
public class Cars implements Vechicle,Sorableby {
    String marka;
    String model;
    int speed;
    int price;
    public Cars(String marka1,String model1,int speed1, int price){
        marka = marka1;
        model = model1;
        speed = speed1;
        this.price = price;
    }
    public void setMarka(String marka1){
        marka = marka1;
    }
    public void setModel(String model1){
        model = model1;
    }



    public void setSpeed(int speed) {
        this.speed = speed;
    }

    public void setPrice(int price) {
        this.price = price;
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
    public int maxSpeed() {
        return speed;
    }

    @Override
    public int Price() {
       return price;
    }
    @Override
    public String getModel() {
        return model;
    }
    @Override
    public String getMarka() {
        return marka;
    }
}
