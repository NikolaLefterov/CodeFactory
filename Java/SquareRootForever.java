
import java.util.Scanner;

public class SquareRootForever {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner (System.in);
        String command = "";
        while(!command.equals("exit")){
            System.out.print("Number:");
            int number = s.nextInt();
            double result = Math.sqrt(number);
            System.out.printf("Square root: %.2f\n", result);
            System.out.print("Command: ");
            command = s.next();
        }
        }
    }
    




