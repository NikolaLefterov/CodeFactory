


import java.util.Scanner;


public class DateTimeString {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
       Scanner s = new Scanner(System.in);
 	  	
         System.out.print("Date and time: ");
 	  	
         String input = s.nextLine();
 	  	
         //expected format: 2016-11-30 17:45
 	  	
         int year = Integer.parseInt(input.substring(0, 4));
 	  	
         int month = Integer.parseInt(input.substring(5, 7));
 	  	
         int day = Integer.parseInt(input.substring(8, 10));
 	  	
         int hour = Integer.parseInt(input.substring(11, 13));
 	  	
         int minutes = Integer.parseInt(input.substring(14, 16));
 	  	
         
 	  	
         if (month < 1 || month > 12) {
 	  	
             System.out.println("Invalid month");
 	  	
             return;
 	  	
         }
 	  	
         if (day < 1 || day > 31) {
 	  	
             System.out.println("Invalid day");
 	  	
             return;
 	  	
         }
 	  	
         if (hour < 0 || hour > 23) {
 	  	
             System.out.println("Invalid hour");
 	  	
             return;
 	  	
         }
 	  	
         if (minutes < 0 || minutes > 59) {
 	  	
             System.out.println("Invalid minutes");
 	  	
             return;
 	  	
         }
 	  	
        
 	  	
         System.out.println("Year: " + year);
 	  	
         System.out.println("Month: " + month);
 	  	
         System.out.println("Day: " + day);
 	  	
         System.out.println("Hour: " + hour);
 	  	
         System.out.println("Minutes: " + minutes);
 	  	
        
 	  	
     }
    
}
