
import java.util.Scanner;


public class EvenOrOddLoop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner (System.in);
 int startFrom, upTo;
 System.out.print("Start from:");
 startFrom = s.nextInt();
 System.out.print("Up to:");
 upTo =s.nextInt();
       for (int x = startFrom; x <= upTo; x++)
       { if (x % 2 == 0) {
    System.out.println(x + " is even");
}
    else {
    System.out.println(x + " is odd");
}
}
    
    }}
