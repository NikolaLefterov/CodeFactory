
import java.util.Scanner;


public class Century {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int year;
       Scanner s = new Scanner(System.in);
       year = s.nextInt();
       if(year < 1901){
           System.out.println("before");
       }
       else if (year >= 1901 && year <=1999){
           System.out.println("during");
       }
       else if(year>=2000){
       System.out.println("after");
       }
        
    }
    
}
