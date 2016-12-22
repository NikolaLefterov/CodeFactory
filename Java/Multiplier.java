
import java.util.Scanner;


public class Multiplier {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int size,number;
      
  Scanner input = new Scanner(System.in);
        
       
 System.out.print("Size: ");
      
  size = input.nextInt();
        
       
 int[] f = new int[size];
        
int[] s = new int[size];
        
       
 for(int i = 0; i < f.length; i++){
          
  System.out.print("first " + i + ": ");
         
   number = input.nextInt();
           
 f[i] = number;
        }
     
   for(int j = 0; j < s.length; j++){
          
  System.out.print("second " + j + ": ");
        
    number = input.nextInt();
          
  s[j] = number;
        }
       
 for(int k = 0; k < size; k++){
            
double res;
            
res = f[k] * s[k];
           
 System.out.println(res);
        }
    }
    
}


