package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int lenght = input.nextInt();
      Cars[] koli = new Cars[lenght];
      Bikes[] motori = new Bikes[lenght];
      String marka,model;
      int cena,skorost;
        for (int i = 0; i <lenght ; i++) {
            System.out.print("vuvedi marka na kolata:");
            marka = input.next();
            System.out.print("vuvedi model na kolata:");
            model = input.next();
            System.out.print("vuvedi maxskorost na kolata:");
            skorost = input.nextInt();
            System.out.print("vuvedi cena na kolata: ");
            cena = input.nextInt();
            koli[i] = new Cars(marka,model,skorost,cena);
        }
        for (int i = 0; i <lenght ; i++) {
            System.out.print("vuvedi marka na motora:");
            marka = input.next();
            System.out.print("vuvedi model na motora:");
            model = input.next();
            System.out.print("vuvedi maxskorost na motora:");
            skorost = input.nextInt();
            System.out.print("vuvedi cena na motora: ");
            cena = input.nextInt();
            motori[i] = new Bikes(marka,model,skorost,cena);
        }
        System.out.println("Sravnenie po skorost ");
        for (int i = 0; i <lenght ; i++) {

            System.out.println(koli[i].compareTo(0,motori[i]));
        }
        System.out.println("Sravnenie po marka ");
        for (int i = 0; i <lenght ; i++) {

            System.out.println(koli[i].compareTo(1,motori[i]));
        }
        System.out.println("Sravnenie po model ");
        for (int i = 0; i <lenght ; i++) {

            System.out.println(koli[i].compareTo(2,motori[i]));
        }
        System.out.println("Sravnenie po cena ");
        for (int i = 0; i <lenght ; i++) {

            System.out.println(koli[i].compareTo(3,motori[i]));
        }


    }
}
