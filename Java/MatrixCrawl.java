package com.company;

import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("vuvedete duljinata");
        int n = input.nextInt();

        int [][] matrix = new int[n][n];
        int [] [] matrix2 = new int[n][n];
        int counter = 0;
        for (int i = 0; i <n; i++) {
            for (int j = 0; j <n ; j++) {
                matrix[i][j] = counter;
                counter++;
            }
        }
        counter =0;
        for (int i = 0; i <n; i++) {
            for (int j = 0; j <n ; j++) {
                matrix2[j][i]=(n*i)+j;
               // counter++;
            }
        }




        for (int i = 0; i <n; i++) {
            for (int j = 0; j <n ; j++) {
                System.out.print(matrix[i][j]+"\t");
            }
            System.out.println();
        }
        System.out.println();
        System.out.println();
        for (int i = 0; i <n; i++) {
            for (int j = 0; j <n ; j++) {
                System.out.print(matrix2[i][j]+"\t");
            }
            System.out.println();
        }
        

       

    }

}
