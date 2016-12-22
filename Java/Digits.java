
import java.util.Scanner;

public class Digits {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner (System.in);
        System.out.print("Enter a number: ");
        String number = s.next();
        int sumOfDigits = 0;
        for(int i = 0; i < number.length(); i++) {
            char c = number.charAt(i);
            int n = Character.getNumericValue(c);
            System.out.printf("digit %d: %c (%d)\n", i+1, c, n);
            sumOfDigits += n;}
            System.out.println("The sumn is " + sumOfDigits);
            
            
        }
    }
    

