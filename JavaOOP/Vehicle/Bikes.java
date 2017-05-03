package com.company;

/**
 * Created by Nikola on 3/29/2017.
 */
public class Bikes extends Vechicle {
    String marka;
    String model;
    public Bikes(String marka1,String Model1, int Speed1){
        marka = marka1;
        model = Model1;
        speed = Speed1;
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
        System.out.println("I'm BIKE!");
    }
}
