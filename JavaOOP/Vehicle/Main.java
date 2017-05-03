package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        /*
        Cars bmw = new Cars("BMW","535d",300);
        System.out.println("Marka: "+ bmw.getMarka());
        System.out.println("Model: "+ bmw.getModel());
        System.out.println("Speed: "+ bmw.getSpeed());
        */
        int lenght = input.nextInt();
        Vechicle[]  koloMotori = new Vechicle[lenght];
        String marka,model;
        int skorost;

        for (int i = 0; i <lenght ; i++) {
            marka = input.next();
            model = input.next();
            skorost = input.nextInt();
            if((i+1) %2 ==0){
                koloMotori[i] = new Cars(marka,model,skorost);
            }
            else{
                koloMotori[i] = new Bikes(marka,model,skorost);
            }
        }
        for (int i = 0; i <lenght ; i++) {
            koloMotori[i].whatIAM();
            System.out.println(koloMotori[i].getSpeed());
        }
        int maxSkorost = 0;
        int position = 0;
        for (int i = 0; i <lenght; i++) {
            if(koloMotori[i].getSpeed()> maxSkorost){
                maxSkorost = koloMotori[i].getSpeed();
                position = i;
            }
        }
        System.out.print("Nai-burzoto prevozno sredstvo e: " + koloMotori[position].getMarka() );
        koloMotori[position].whatIAM();
        System.out.println("Sus skorost: " + maxSkorost);
    }
}
