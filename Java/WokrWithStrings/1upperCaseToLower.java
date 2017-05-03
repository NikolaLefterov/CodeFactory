package com.company;

import java.lang.String;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String inputtext = input.next();
        StringBuilder text = new StringBuilder(inputtext);
        for (int i = 0; i <text.length() ; i++) {
            int ascii = (int) inputtext.charAt(i) +32;
            char replace = (char) ascii;
            if((int) inputtext.charAt(i) >=65 & (int) inputtext.charAt(i) <=90){
                 text.setCharAt(i,replace);
            }
        }
        System.out.println(text);
    }
}
