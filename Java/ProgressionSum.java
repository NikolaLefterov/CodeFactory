

public class ProgressionSum {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
       int a1,d,n,sum;
       System.out.println("Please enter value of the first element: ");
       a1 = s.nextInt();
       System.out.println("Please enter value of the step: ");
       d = s.nextInt();
       System.out.println("Please enter the number of the last element: ");
       n = s.nextInt();
       sum =(((2*a1)+(n-1)*d)/2)*n;
       System.out.println("The sum of the first " + n + " elements is "+ sum);
    }
    
}
