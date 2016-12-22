
import java.util.Scanner;

public class Fibonacci {

 public static  int fibo(int n){
 if(n <= 1){
  return n;
 }
 int fibo = 1;
 int fiboPrev = 1;
 for(int i = 2; i < n; ++i){
  int temp = fibo;
  fibo += fiboPrev;
  fiboPrev = temp;
 }
 return fibo;
}
 
    public static void main(String[] args) {
        int limit;
        Scanner s = new Scanner(System.in);
        System.out.print("Limit: ");
        limit = s.nextInt();
        for(int i =0;i<limit;i++){
          System.out.println(fibo(i)); 
        }
        
        
        
           }
    
}
