
import java.util.Scanner;

public class ConeVolume {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         Scanner s = new Scanner(System.in);
        double r,h,V;
        System.out.println("Enter the radius: ");
        r = s.nextDouble();
        System.out.println("Enter the height: ");
        h = s.nextDouble();
        V = (((1.0/3.0)*Math.PI)*(r*r))*h;
        System.out.println("The volume of the cone is "+V);
    }
    
}
