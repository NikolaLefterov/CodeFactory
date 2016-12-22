
import java.util.Scanner;


public class ArithmeticProgression {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int a1,n,d;
        System.out.println("Please enter the value of the first element:");
        a1 = s.nextInt();
        System.out.println("Please enter the value of the step:");
        d = s.nextInt();
        System.out.println("Please enter the number of the element you'd want to be calculated: :");
        n = s.nextInt();
        int AP;
        
       
        AP=a1+(n-1)*d;
        System.out.println("Element "+n + " is " +AP);
    }
    
}
