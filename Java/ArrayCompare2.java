
import java.util.Scanner;

public class ArrayCompare2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      Scanner s = new Scanner(System.in);
      int firstArray;
      int secondArray;
      System.out.print("How many in the first array? ");
      firstArray = s.nextInt();
      System.out.print("How many in the second array? ");
      secondArray = s.nextInt();
      double[] arr1 = new double[firstArray];
      String[] arr2 = new String[secondArray];
      int[] matches = new int[(firstArray < secondArray ? firstArray : secondArray)];
      for(int i = 0; i < firstArray; i++){
          System.out.print("1st array number: ");
          arr1[i] = s.nextDouble();
         }
       for(int i = 0; i < secondArray; i++){
          System.out.print("2st array number: ");
          arr2[i] = s.next();
       }
       int matchCounter = 0;
       for(int i = 0; i < firstArray; i++){
           for(int j = 0; j < secondArray; j++) {
               int x = (int)arr1[i];
               int y = Integer.parseInt(arr2[j]);
               if(x == y){
                   matches[matchCounter] = x;
                   System.out.printf("Match: %d\n" , matches[matchCounter]);
                   matchCounter++;
                   
               }
               
           }
       }
    }
}

      
      
    
    
