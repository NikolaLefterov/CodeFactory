
import java.util.Scanner;

public class Hypotenuse2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
         double a,b,c;
         System.out.println("Enter a: ");
         a = s.nextInt();
         System.out.println("Enter b: ");
         b = s.nextInt();
         c = Math.sqrt((a*a)+(b*b));
         System.out.println("The length is " + c);
    }
    
}
