
import java.util.Scanner;

public class MatrixHorizontal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     int rows, cols;
       
 Scanner s = new Scanner(System.in);

       
 System.out.print("How many rows? ");
      
  rows = s.nextInt();
       
 System.out.print("How many columns? ");
        
cols = s.nextInt();

       
 int[][] matrix = new int[rows][cols];

      
  for(int i = 0; i < matrix.length; i++) {
           
 for (int j = 0; j < matrix[i].length; j++) {
               
 matrix[i][j] = 1 + j + i*matrix[i].length; 
            }
        }
        
     
   for (int i = 0; i < matrix.length; i++) {
          
  for (int j = 0; j < matrix[i].length; j++) {
               
 System.out.printf("%d\t", matrix[i][j]);
            }
            
System.out.println();
        }
    }

}
