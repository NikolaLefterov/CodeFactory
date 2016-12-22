
import java.util.Scanner;


public class WorldMap2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     double latitude1, longitude1,latitude2, longitude2;
        Scanner s = new Scanner(System.in);
          System.out.print("Latitude 1: ");
          latitude1 = s.nextDouble();
          System.out.print("Longitude 1: ");
          longitude1 = s.nextDouble();
          while(true) {
        System.out.print("Latitude 2: ");
        latitude2 = s.nextDouble();
        System.out.print("Longitude 2: ");
        longitude2 = s.nextDouble();
        System.out.printf("GPS1 : %f %f\n", latitude1, longitude1);
        System.out.printf("GPS2 : %f %f\n", latitude2, longitude2);
        if(latitude2 > latitude1 && longitude2 == longitude1){
            System.out.print("This is the same place");
           return;
        }if(latitude2 > latitude1 && longitude2 > longitude1){
            System.out.println("NORTHEAST");
            }if(latitude2 > latitude1 && longitude2 < longitude1){
            System.out.println("NORTHWEST");
        }if(latitude2 < latitude1 && longitude2 > longitude1){
            System.out.println("SOUTHEAST");
        }if(latitude2 < latitude1 && longitude2 < longitude1){
            System.out.println("SOUTHWEST");
        }if(latitude2 > latitude1 && longitude2 == longitude1){
            System.out.println("NORTH");
        }if(latitude2 < latitude1 && longitude2 == longitude1){
            System.out.println("SOUTH");
        }if(latitude2 == latitude1 && longitude2 > longitude1){
            System.out.println("EAST");
        }if(latitude2 == latitude1 && longitude2 < longitude1){
            System.out.println("(WEST");



          }
    }
    
}
}


