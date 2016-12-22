
import java.util.Scanner;

public class Lotto {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      int[] numbers = new int[6];
      
  int count = 0;
    
    Scanner input = new Scanner(System.in);
     
   System.out.println("Enter 6 numbers:");

     
   for (int i = 0; i < numbers.length; i++) {
        
    int number = input.nextInt();
         
   if (number > 47 || number < 1) {
               
 System.out.println("Only between 1 and 47!");
             
   i = i - 1;
               
 continue;
            }  
else {
             
   numbers[i] = number;
            }
        }
        
    
    int[] choices = new int[6];
       
 for(int j = 0; j < choices.length; j++){
         
   int x = new java.util.Random().nextInt(46) + 1;
            
choices[j] = x;
        }
       
 System.out.println("Lotto numbers: ");
        
for(int j = 0; j < choices.length; j++){
        
    System.out.printf("%d\t", choices[j]);
        }
      
  for(int k = 0; k < choices.length; k++){
            
if(numbers[k] == choices[k]){
               
 count = count + 1 ;
            }
        }
      
  System.out.println("\nYou guessed " + count + " numbers!");
    }

}
