package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Person[] Hora = new Person[3];
        Hora[0] = new Student(20,"Pesho","f79561");
        Hora[1] = new GraduateStudent(20,"Gosho","f79569",5.5);
        Hora[2] = new Teacher(35,"Nikola",300);

        for (int i = 0; i <3 ; i++) {
            Hora[i].WhoIAM();
            System.out.println(Hora[i]);
        }
        Hora[0].CompareTo(Hora[1]);
        String[] imena = new String[3] ;
        for (int i = 0; i <3 ; i++) {
            imena[i] = Hora[i].getName();

        }
        Arrays.sort(imena);
        System.out.println(imena[1]);
    }
}
