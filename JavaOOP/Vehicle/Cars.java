package com.company;

/**
 * Created by Nikola on 3/29/2017.
 */
public class Cars extends Vechicle {
    String marka;
    String model;
    public Cars(String marka1,String model1,int speed1){
        marka = marka1;
        model = model1;
        speed = speed1;
    }
    public void setMarka(String marka1){
        marka = marka1;
    }
    public void setModel(String model1){
        model = model1;
    }
    @Override
    public String getMarka(){
        return marka;

    }
    @Override
    public String getModel(){
        return model;
    }

    @Override
    void whatIAM() {
        System.out.println("I'm CAR!");
    }
}
