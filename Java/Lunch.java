
import java.util.Scanner;


public class Lunch {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double bill;
        double paid=0;
        int people;
        Scanner s = new Scanner(System.in);
        System.out.print("What is the bill? ");
        bill = s.nextDouble();
        System.out.print("How many of you are there? ");
        people = s.nextInt();
        for(int i=1;i<=people;i++){
            double give;
            System.out.print("Person "+ i+  " gives : ");
            give= s.nextDouble();
            paid+=give;
        }
        System.out.printf("Paid: %.2f\n", paid);
        double r = Math.abs(paid-bill);
        if(paid<bill){
            System.out.printf("%.2f leva left to pay the bill\n",r);
        }
        else if(paid>bill){
            System.out.printf("Tip: %.2f\n",r);
        }
    }
    
}



