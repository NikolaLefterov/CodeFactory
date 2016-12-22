
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
        if(r <0 || r== 0){
            System.out.println("Radius must be > 0");
            return
        }
        
        System.out.println("Enter the height: ");
        h = s.nextDouble();
         if(h<0 || h == 0){
        System.out.println("Height must be > 0");
        return;
        }
        V = (((1.0/3.0)*Math.PI)*(r*r))*h;
        System.out.println("The volume of the cone is "+V);
    }
    
}
