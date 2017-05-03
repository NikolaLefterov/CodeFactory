package com.company;
        import java.util.Scanner;
public class Main {

    public static int[] insertArray(int[] arr, int insert, int position){

        int [] insertt = new int[arr.length+1];
        int counter = 0;
        for (int i = 0; i <insertt.length ; i++) {

            if(i == position-1){
                insertt[i]= insert;

                continue;
            }
            insertt[i] = arr[counter++];
        }

        return insertt;
    }
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("enter lenght of array:");
        int n;
        n = input.nextInt();
        int [] numbers = new int[n];
        for (int i = 0; i <n ; i++) {
            numbers[i] = input.nextInt();
        }
        int insertNumber=0;
        System.out.println("Number to insert:");
        insertNumber = input.nextInt();
        int insertPostion =0;
        System.out.println("Position number");
        insertPostion = input.nextInt();

        int [] newArray= insertArray(numbers,insertNumber,insertPostion);

        for (int i = 0; i <newArray.length ; i++) {
            System.out.println(newArray[i]);
        }
    }
}