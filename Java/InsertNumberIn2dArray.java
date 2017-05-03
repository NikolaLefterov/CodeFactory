package com.company;
        import java.util.Scanner;
public class Main {

    public static int[][] insertArray(int[][] arr, int insert, int position2, int n){

        int [][] insertt = new int[n][n+1];

        int counter2 = 0;
        for (int i = 0; i <n ; i++) {
            for (int j = 0; j <n+1 ; j++) {

                if( j == position2-1){
                    insertt[i][j]= insert;


                    continue;
                }
                insertt[i][j] = arr[i][counter2++];

            }
                counter2=0;

        }

        return insertt;
    }
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("enter lenght of array:");
        int n;
        n = input.nextInt();
        int [][] numbers = new int[n][n];
        for (int i = 0; i <n ; i++) {
            for (int j = 0; j <n ; j++) {
                numbers[i][j] = input.nextInt();
            }
        }
        int insertNumber=0;
        System.out.println("Number to insert:");
        insertNumber = input.nextInt();

        int insertPostion2 =0;
        System.out.println("position2 ");
        insertPostion2 = input.nextInt();

        int [][] newArray= insertArray(numbers,insertNumber,insertPostion2,n);

        for (int i = 0; i <n ; i++) {
            for (int j = 0; j <n+1 ; j++) {
                System.out.println(newArray[i][j]);
            }
            System.out.println();
        }
    }
}