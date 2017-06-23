//package com.company;

import java.util.Scanner;

public class Main {

    public static boolean isPalindrome(String word){
        boolean flag = false;
        StringBuilder reverse = new StringBuilder(word);
        if(word.equalsIgnoreCase(reverse.reverse().toString())){
            flag =  true;
        }
        return  flag;
    }
    public static boolean isPalindromeAlgo(String word){
        boolean flag = true;
        for (int i = 0; i <word.length()/2 ; i++) {
            if(word.charAt(i) != word.charAt(word.length()-i-1)){
                flag= false;
            }
        }
        return flag;
    }

    public static String LongestPalindromFinder(String str,int start,int end){
        while(start>=0 && end<=str.length()-1 && str.charAt(start)==str.charAt(end)){
            start--;
            end++;
        }
        return str.substring(start+1,end);
    }
    public static String mostUpperCaseFinder(String str, int start, int end){
        if(str.charAt(start) == ' '){
            start--;
            end++;
        }
        while(start>=0 && end<=str.length()-1 && str.charAt(start)==str.charAt(end) && str.charAt(start)>=65 && str.charAt(start)<=90  &&str.charAt(end)>=65 &&str.charAt(end)<=95 ){
            start--;
            end++;
        }
        if(end<=0 || start==end){
            return str.substring(0,1);
        }
        else
            return str.substring(start+1,end);
    }
    public static String longestPalindrome(String str){
        String result= str.substring(0,1);

        for (int i = 0; i <str.length() ; i++) {
            String tmp = LongestPalindromFinder(str,i,i);
            if(tmp.length()> result.length()){
                result = tmp;
            }
            tmp = LongestPalindromFinder(str,i,i+1);

            if(tmp.length()> result.length()){
                result = tmp;
            }
        }
        return result;
    }


    public static String mostUpperCase(String str){
        String result= str.substring(0,1);
        for (int i = 0; i <str.length() ; i++) {
            String tmp = mostUpperCaseFinder(str,i,i);
            if(tmp.length()> result.length()){
                result = tmp;
            }

            tmp = mostUpperCaseFinder(str,i,i+1);

            if(tmp.length()> result.length()){
                result = tmp;
            }
            if(result.length() == 1){
                result = " ";
            }

        }
        return result;
    }

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String word = input.nextLine();
        if(isPalindrome(word)){
            System.out.println("The word is palindrom!");
        }
        else{
            System.out.println("The word is not a palindrome!");
        }
        if(isPalindromeAlgo(word)){
            System.out.println("The word is palindrom!");
        }
        else{
            System.out.println("The word is not a palindrome!");
        }
        String str = input.nextLine();
        System.out.println(longestPalindrome(str));
        System.out.println(mostUpperCase(str));

    }
}
