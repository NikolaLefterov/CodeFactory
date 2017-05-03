package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Team[] otbori = new Team[2];
        String ime;
        int broi;
        for (int i = 0; i <2 ; i++) {
            ime = input.next();
            broi = input.nextInt();
            if(i%2==0){
                otbori[i] = new FootballTeam(ime,broi);
            }
            else{
                otbori[i] = new BasketballTeam(ime,broi);
            }
        }
        for (int i = 0; i <2 ; i++) {
            System.out.println(otbori[i]);
        }
    }
}
