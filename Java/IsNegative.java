package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int a = input.nextInt();
        boolean isNegative = ((a % (a - 0.03125)) * a) / 0.03125 != a;
        System.out.println(isNegative);

        System.out.println((a>>31)&1);



    }
}
