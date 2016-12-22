
import java.util.Scanner;
import java.util.Collections;

import java.util.Arrays;

import java.util.List;

public class Excel2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
         int number;
        String func = null;
        System.out.print("How many numbers? ");
         number = s.nextInt();
         int[] chars = new int[number];

 for (int i = 0; i < number; i++) {
  int count = i + 1;
 System.out.print("Number " + count + ": ");
 chars[i] = s.nextInt();
        }
  System.out.print("Function? ");
  func = s.next();

        
if (func.equals("SUM")) {
          
  double sum = 0;
           
 for (int el : chars) {
              
  sum = sum + el;
            }
           
 System.out.println("Result: " + sum);

        } 
else if (func.equals("AVERAGE")) {
           
 double sum = 0;
           
 double result = 0;

           
 for (int el : chars) {
               
 sum = sum + el;
                
result = sum / number;
            }
          
  System.out.println("Result: " + result);

        } 
else if (func.equals("COUNT")) {

            
int result = chars.length;
           
 System.out.println("Result: " + result);

        } 
else if (func.equals("MIN")) {

            
int min = Arrays.stream(chars).min().getAsInt();
           
 System.out.println("Result: " + min);

        } 
else if (func.equals("MAX")) {

            
int max = Arrays.stream(chars).max().getAsInt();
         
   System.out.println("Result: " + max);

        }  
else{
           
 System.out.println("Unsupported function");
        }

   
  

  

 
        
 
 
      
      }
    }