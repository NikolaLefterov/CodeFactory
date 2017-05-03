package com.company;

/**
 * Created by Nikola on 3/22/2017.
 */
public class Singleton {

    private final static Singleton instance;


    static {
        instance =  new Singleton() ;
    }


    public static Singleton getInstance() {
        return instance;
    }


    private Singleton() {
    }
}