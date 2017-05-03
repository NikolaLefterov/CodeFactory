package com.company;

import java.lang.String;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String maluk = input.next();
        String golqm = input.next();
        int malukbroqch =0;
        int counter = 0;
        for (int i = 0; i <golqm.length() ; i++) {

            if(maluk.charAt(malukbroqch) == golqm.charAt(i)){
                malukbroqch++;
            }
            if(malukbroqch == maluk.length()){
                counter++;
                malukbroqch =0;
            }
        }
        System.out.println(counter);
    }
}
