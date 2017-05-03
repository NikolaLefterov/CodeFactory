package com.company;

/**
 * Created by Nikola on 4/12/2017.
 */
abstract class Person {
    protected int age;
    protected  String name;
    public Person(){
        this.age = age;
        this.name = name;
    }
    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }
    abstract String getName();
    abstract int getAge();
    public void CompareTo(Person other){
        if(this.age == other.getAge()){
            System.out.println(this.name +" and " + other.getName()+" are on the same age");

        }
        else if(this.age > other.getAge() )
        {
            System.out.println("Person: " +this.name +" is older than " + other.getName());
        }
        else{
            System.out.println("Person: " +other.getName() +" is older than " +this.name );
        }

    }
    abstract void WhoIAM();
}
