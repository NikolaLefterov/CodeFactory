
 import java.util.Scanner;


public class AirConditioner {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner s = new Scanner(System.in);
       
     int temp;
     int extemp = 0, intemp = 0, desiredtemp = 0;
     System.out.print("External temp:");
     temp = s.nextInt();
     System.out.print("Internal temp:");
     temp = s.nextInt();
     System.out.print("Desired temp:");
     temp = s.nextInt();
     if (desiredtemp < intemp && extemp > intemp){
         System.out.print("MAX COLD MODE");
         } else if (desiredtemp < intemp || extemp <= intemp){
             System.out.print("ENERGY SAVING COLD MODE");
         } else if (desiredtemp > intemp && extemp < intemp){
             System.out.print("MAX WARM MODE");
         } else if (desiredtemp > intemp && extemp >= intemp){
             System.out.print("ENERGY SAVING WARM MODE");}
     
             
         }
             
     
       
       
     

    }
    

