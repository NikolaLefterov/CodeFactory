

import java.util.Scanner;


public class DigitNames {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s=new Scanner(System.in);
        String number;
        System.out.print("Number: ");
         number=s.next();
         String[]names = { "zero", "one", "two", "three", "four", "five",
"six", "seven", "eight", "nine" };
         
          int[] chars = new int[number.length()];
          
          for(int i=0;i<number.length();i++)
          { 
              chars[i] = Integer.parseInt(number.substring(i, i+1));
              
          }
         for(int c:chars ){
             switch(c){
                  case 0 : System.out.println(names[0]); break;   
                  case 1 : System.out.println(names[1]); break;
                  case 2 : System.out.println(names[2]); break;
                  case 3 : System.out.println(names[3]); break;
                  case 4 : System.out.println(names[4]); break;
                  case 5 : System.out.println(names[5]); break;
                  case 6 : System.out.println(names[6]); break;
                  case 7 : System.out.println(names[7]); break;
                  case 8 : System.out.println(names[8]); break;
                  case 9 : System.out.println(names[9]); break;

                  
             }
             
             
         } 

        
        
    }
    
}
