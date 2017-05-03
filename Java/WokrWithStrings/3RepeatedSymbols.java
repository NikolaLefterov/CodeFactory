package com.company;

import java.lang.String;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String inputtext = input.next();
        boolean flag = false;
        int counter = 1;
        for (int i = 0; i <inputtext.length() ; i++) {
            for (int j = i+1; j <inputtext.length() ; j++) {

                if( inputtext.charAt(i) == inputtext.charAt(j)) {

                    counter++;
                }

            }
            if(counter >=3 ){
                flag = true;
                break;
            }


            counter =1;
        }
        System.out.println(flag);

    }
}
