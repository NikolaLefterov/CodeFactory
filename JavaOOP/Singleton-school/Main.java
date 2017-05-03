package com.company;



import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner input = new Scanner(System.in);
	    int lenght = input.nextInt();
        School[] SOfiqUchilishta  = new School[3];
        String name;
        int a;
        int b;
        for (int i = 0; i <lenght ; i++) {
            SOfiqUchilishta[i] = new School();
            System.out.println("name of school");
            name = input.next();
            System.out.println("broi uchiteli");
            a = input.nextInt();
            System.out.println("broi uchenici");
            b = input.nextInt();
            SOfiqUchilishta[i].setSchoolname(name);
            SOfiqUchilishta[i].setBroiUchiteli(a);
            SOfiqUchilishta[i].setBroiUchenici(b);
        }
        for (int i = 0; i <lenght ; i++) {
            System.out.print("Ime na uchilishte nomer " +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getName());
            System.out.print("Broi na uchitelite v uchilishte nomer" +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getUchiteli());
            System.out.print("Broi na uchenicite v uchiliste nomer" +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getBroiUchenici());
        }
        int maxUchenici = 0;
        int position= 0;
        for (int i = 0; i <lenght ; i++) {
            if(maxUchenici < SOfiqUchilishta[i].getBroiUchenici()){
                maxUchenici = SOfiqUchilishta[i].getBroiUchenici();
                position = i;
            }
        }
        System.out.println("Nai mnogo uchenici ima v uchislite noemr " + (position+1));
        System.out.println(SOfiqUchilishta[position].getName());
        System.out.println(SOfiqUchilishta[position].getUchiteli());
        System.out.println(SOfiqUchilishta[position].getBroiUchenici());
        System.out.println(Singleton.getInstance());

       Singleton first = Singleton.getInstance();
       Singleton second = Singleton.getInstance();
        System.out.println(first);
        System.out.println(second);
        School temp = new School();
        for (int i = 0; i <lenght ; i++) {
            for (int j = i+1; j <lenght ; j++) {
                if(SOfiqUchilishta[i].getBroiUchenici() > SOfiqUchilishta[j].getBroiUchenici()){
                    temp = SOfiqUchilishta[i];
                    SOfiqUchilishta[i] = SOfiqUchilishta[j];
                    SOfiqUchilishta[j] = temp;
                }
            }
        }
        for (int i = 0; i <lenght ; i++) {
            System.out.print("Ime na uchilishte nomer " +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getName());
            System.out.print("Broi na uchitelite v uchilishte nomer" +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getUchiteli());
            System.out.print("Broi na uchenicite v uchiliste nomer" +(i+1)+" ");
            System.out.println(SOfiqUchilishta[i].getBroiUchenici());
        }
    }
}
