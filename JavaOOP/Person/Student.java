package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class Student extends Person {
    protected String facNum;


    public Student(){

    }
    public Student (int age, String name,String facNum){
        super.setAge(age);
        super.setName(name);
        this.facNum= facNum;

    }


    public void setFacNum(String facNum) {
        this.facNum = facNum;
    }


    @Override
    int getAge() {
        return age;
    }

    @Override
    String getName() {
        return name;
    }


    public String getFacNum() {
        return facNum;
    }

    @Override
    public void WhoIAM(){
        System.out.println("I'm a Student");
    }

    @Override
    public String toString(){
        return  "Godini: " + age + " Ime: " + name +" Fak nomer: " + facNum ;

    }
}
