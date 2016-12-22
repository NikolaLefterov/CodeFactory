
package bg.unwe;

public class TempConverter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        double fahrenheit = 98;
        double celsius ;
        celsius = ((fahrenheit -32)/9)*5;
        System.out.println("Temperature in Fahrenheit is: " + fahrenheit);
        System.out.println("Temperature in Celsius is: " + celsius);

    }
    
}
