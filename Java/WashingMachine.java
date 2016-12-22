
import java.util.Scanner;

public class WashingMachine {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int program ;
        
        System.out.print("Pick a programme: ");
        program = s.nextInt();
        if(program == 1){
            System.out.println("Temperature: 60 degrees, Time: 125 minutes");
        }
        else if(program == 2){
            System.out.println("Temperature: 90 degrees, Time: 106 minutes");
        }
        else if(program == 3){
            System.out.println("Temperature: 40 degrees, Time: 98 minutes");
        }
        else if(program == 4){
            System.out.println("Temperature: 50 degrees, Time: 65 minutes");
        }
        else if(program == 5){
         System.out.print("Desired temperature: ");
         int dTemp;
         dTemp = s.nextInt();
         
         System.out.print("Desired time: ");
         int dTime;
         dTime = s.nextInt();
            System.out.println("Temperature: " +dTemp +" degrees, Time: "+ dTime +" minutes");
        }
        else{
            System.out.println("No such programme");
        }
        
    }
    
}
