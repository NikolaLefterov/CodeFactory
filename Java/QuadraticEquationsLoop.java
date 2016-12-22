
import java.util.Scanner;

public class QuadraticEquationsLoop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
       Scanner s = new Scanner(System.in);
       int limit;
       limit = s.nextInt();
       int a,b,c;
       double D,x1,x2;
       for(int i=1 ;i <= limit; i++){
       for(int j=1;j<=limit;j++){
       for(int k=1;k<=limit;k++){
        a=i;
        b=j;
        c=k;
        
     
       System.out.println("a= "+a+", b= "+b+", c= "+c);
      
       
        D =((Math.pow(b,2))-(4*a*c));
            if(D>0){
            x1=(-b + (Math.sqrt(D))) / (2*a);
            x2=(-b - (Math.sqrt(D))) / (2*a);
            System.out.println("x1= " + x1);
            System.out.println("x2= " + x2);
                   }
            else if(D<0){
            System.out.println( "No solution");
                       
                        
               }
            else if(D==0){
                x1=(-b + (Math.sqrt(D))) / (2*a);
                System.out.println("x1= " + x1);
                
            }
               }
           }
       }
    }
}