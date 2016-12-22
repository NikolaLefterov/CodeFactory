
import java.util.Scanner;

public class SumIfLarger {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args){
        
    
    Scanner s = new Scanner(System.in);
    int n= 0;
    int previous = 0;
    int sum=0;
            
    System.out.print("Next: ");
        while(s.hasNextInt()) {
            
            previous = n;
            System.out.print("Next: ");
            n = s.nextInt();
            if(n>previous || n==previous ){
                sum += n;
            }
            else {
                System.out.println("Result: "+sum);
                break;
            }
}
    
    
}
}
