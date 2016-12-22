
import java.util.Scanner;

public class WorldMap1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double latitude1, longitude1, latitude2, longitude2;
        Scanner s = new Scanner(System.in);
        System.out.print("latitude1:");
        latitude1 = s.nextDouble();
        System.out.print("longitude1:");
        longitude1 = s.nextDouble();
        System.out.print("latitude2:");
        latitude2 = s.nextDouble();
        System.out.print("longitude2:");
        longitude2 = s.nextDouble();
        System.out.printf("GPS1 : %f %f\n", latitude1, longitude1);
        System.out.printf("GPS2 : %f %f\n", latitude2, longitude2);
        if(latitude1 == latitude2 && longitude1 == longitude2){
            System.out.print("This is the same place");
            return;
        }if(latitude2 > latitude1 && longitude2 > longitude1){
            System.out.print("NORTHEAST");
        }if(latitude2 > latitude1 && longitude2 < longitude1){
            System.out.print("NORTHWEST");
        }if(latitude2 < latitude1 && longitude2 > longitude1){
            System.out.print("SOUTHEAST");
        }if(latitude2 < latitude1 && longitude2 < longitude1){
            System.out.print("SOUTHWEST");
        }if(latitude2 > latitude1 && longitude2 == longitude1){
            System.out.print("NORTH");
        }if(latitude2 < latitude1 && longitude2 == longitude1){
            System.out.print("SOUTH");
        }if(latitude2 == latitude1 && longitude2 > longitude1){
            System.out.print("EAST");
        }if(latitude2 == latitude1 && longitude2 < longitude1){
            System.out.print("(WEST");
        }
    }
    
}
