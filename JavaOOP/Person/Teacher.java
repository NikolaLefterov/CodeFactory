package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
public class Teacher extends Person {
    protected int hours;

    public Teacher(int age, String name,int hours){
        super.setAge(age);
        super.setName(name);
        this.hours= hours;
    }

    @Override
    public void setAge(int age) {
        super.setAge(age);
    }

    @Override
    public void setName(String name) {
        super.setName(name);
    }

    public void setHours(int hours) {
        this.hours = hours;
    }

    public int getHours() {
        return hours;
    }

    @Override
    int getAge() {
        return age;
    }

    @Override
    String getName() {
        return name;
    }

    @Override
    public void WhoIAM(){
        System.out.println("I'm a Teacher");
    }

    @Override
    public String toString(){
        return  "Godini: " + age + " Ime: " + name +" Chasove rabota: " + hours ;

    }
}
