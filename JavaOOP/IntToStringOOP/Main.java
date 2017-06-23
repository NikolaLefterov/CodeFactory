package com.company;

import java.io.*;
import java.util.Random;
public class Main {

    public static void main(String[] args) throws IOException {
                FileReader file = null;
                file = new FileReader("numbers.txt");
        try{
                 file = new FileReader("numbers.txt");

            }catch(FileNotFoundException fnfe){
                int n = 10;
                Random rng = new Random();
            PrintWriter writer = new PrintWriter("numbers.txt");
                while(n>0){
                    int i = rng.nextInt(900)+100;
                    writer.println(i);
                    n--;
                }
            writer.flush();
            writer.close();
            }





        file = new FileReader("numbers.txt");
        BufferedReader buffer = new BufferedReader(file);
        PrintWriter stringOutput = new PrintWriter("IntToString.txt");
            String line;

            while((line=buffer.readLine())!=null){
                try{
                for (int i = 0; i <line.length() ; i++) {
                    if(line.charAt(i)>=48 && line.charAt(i)<=57) {
                        int character = line.charAt(i) + 49;
                        stringOutput.print((char) character);
                    }
                    else{throw new WrongFormatException();

                    }
                }
                stringOutput.println();
            }catch(WrongFormatException we){
                    stringOutput.println("error");
                }
        }

        stringOutput.flush();
        stringOutput.close();


    }
}
