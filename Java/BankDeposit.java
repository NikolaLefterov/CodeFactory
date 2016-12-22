
import java.util.Scanner;
import java.text.DecimalFormat;

public class BankDeposit {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       double sum;
        
        double summonth = 0, sumyear = 0, sumyears = 0;
        Scanner s = new Scanner(System.in);
         DecimalFormat df = new DecimalFormat("####.#");     
       
        sum = s.nextInt();
        
        
        if (sum < 1000 && sum > 0){
        summonth = (sum*0.5)/100;
        sumyear = (sum*0.9)/100;
        sumyears = (sum*1.5)/100;
        
        System.out.println("1 month - 0.5% - " +summonth);
        System.out.println("1 year - 0.9% - " + sumyear);
        System.out.println("2 years - 1.5% - " + sumyears);
    }
        else if(sum >= 1000 && sum <= 100000){
        summonth = (sum*0.6)/100;
        sumyear = (sum*1.0)/100;
        sumyears = (sum*1.8)/100;
       System.out.println("1 month - 0.6% - " +summonth);
        System.out.println("1 year - 1.0% - " + sumyear);
        System.out.println("2 years - 1.8% - " + sumyears);
                }    
              

        else if (sum >= 100000){
        summonth = (sum*0.8)/100;
        sumyear = (sum*1.2)/100;
        sumyears = (sum*2.2)/100;
      
        System.out.println("1 month - 0.8% - " +summonth);
        System.out.println("1 year - 1.2% - " + sumyear);
                sumyears = Double.valueOf(df.format(sumyears)); 
        System.out.println("2 years - 2.2% - " + sumyears);
        }
               else if (sum == 0 || sum <0){
                System.out.println("Amount must be greater than zero");
                }
    
}
}



              
              


              
              
