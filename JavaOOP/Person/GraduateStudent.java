package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class GraduateStudent extends Student {
    double mark ;
    public GraduateStudent(int age, String name,String facNum,double mark){
        super.setAge(age);
        super.setName(name);
        super.setFacNum(facNum);
        this.mark = mark;
    }

    public void setMark(double mark) {

        this.mark = mark;
    }

    public double getMark() {

        return mark;
    }

    @Override
    public void WhoIAM(){

        System.out.println("I'm a GraduatedStudent");
    }

    @Override
    public String toString(){
        return  "Godini: " + age + " Ime: " + name +" Fak nomer: " + facNum  +" God.uspeh :" + mark;

    }
}
