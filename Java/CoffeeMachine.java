
import java.util.Scanner;

public class CoffeeMachine {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner (System.in);
       double sum;
       
      
       System.out.print("Amount: ");
       sum = s.nextDouble();
       System.out.println("1. short espresso\t0.50");
       System.out.println("2. long espresso\t0.60");
       System.out.println("3. cappuccino\t0.85");
       System.out.println("4. coffee with milk\t0.90");
       System.out.println("5. caffeinefree\t0.60");
        int selection ;
        System.out.print("Your choice: ");
       selection = s.nextInt();
       if(selection == 1){
           if(sum < 0.50){
               System.out.println("Not enough money");
           }
           else if(sum == 0.50){
               System.out.println("Preparing your drink...");
           }
           else if(sum > 0.50){
                System.out.println("Preparing your drink...");
                 System.out.println("Change: "+ (sum-0.50));
           }
       }
      else  if(selection == 2){
           if(sum < 0.60){
               System.out.println("Not enough money");
           }
           else if(sum == 0.60){
               System.out.println("Preparing your drink...");
           }
           else if(sum > 0.60){
                System.out.println("Preparing your drink...");
                 System.out.println("Change: "+ (sum-0.60));
           }
       }
      else   if(selection == 3){
           if(sum < 0.85){
               System.out.println("Not enough money");
           }
           else if(sum == 0.85){
               System.out.println("Preparing your drink...");
           }
           else if(sum > 0.85){
                System.out.println("Preparing your drink...");
                 System.out.println("Change: "+ (sum-0.85));
           }
       }
        else  if(selection == 4){
           if(sum < 0.90){
               System.out.println("Not enough money");
           }
           else if(sum == 0.90){
               System.out.println("Preparing your drink...");
           }
           else if(sum > 0.90){
                System.out.println("Preparing your drink...");
                 System.out.println("Change: "+ (sum-0.90));
           }
       }
         else  if(selection == 5){
           if(sum < 0.60){
               System.out.println("Not enough money");
           }
           else if(sum == 0.60){
               System.out.println("Preparing your drink...");
           }
           else if(sum > 0.60){
                System.out.println("Preparing your drink...");
                 System.out.println("Change: "+ (sum-0.610));
           }
       }
           else {
             System.out.println("Please selefct from the menu");
             
         }
    } 
    
}
