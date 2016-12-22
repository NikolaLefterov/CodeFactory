
import java.text.DecimalFormat;
import java.util.Scanner;

public class ConeVolumeLoop {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
         Scanner s = new Scanner(System.in);
        double r,h,V;
        DecimalFormat df = new DecimalFormat("####0.00");
      
        System.out.print("Max Radius: ");
        r = s.nextDouble();
        System.out.print("Max Height: ");
        h = s.nextDouble();
        for(int i=1;i<=r;i++){
            for(int j=1;j<=h;j++){
            V = (((1.0/3.0)*Math.PI)*(i*i))*j;
             
            System.out.println("radius "+i +", height "+j+":");
           
           System.out.println("volume: "+df.format(V));
            }
        
        }
        
    }
    
}
