package com.company;

/**
 * Created by Nikola on 3/22/2017.
 */
public class School {
   private String schoolname;
   private int broiUchiteli;
   private int broiUchenici;

   public School(){
       schoolname = "no name";
       broiUchiteli = 1;
       broiUchenici = 1;
   }
    public String getName(){
       return schoolname;
    }
    public int getUchiteli(){
        return broiUchiteli;
    }
    public int getBroiUchenici(){
        return broiUchenici;
    }
    public void setSchoolname(String s){
        schoolname = s;
    }
    public void setBroiUchiteli(int n){
        broiUchiteli = n;
    }
    public void setBroiUchenici(int n){
        broiUchenici = n;
    }

}
