
public class TimeCalculator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double seconds = 1540800;
        double minutes;
        double hours;
        double days;
        double weeks;
        double years;
        minutes = seconds / 60;
        hours = minutes /60;
        days = hours / 24;
        weeks = days / 7;
        years = days / 365;
        System.out.println("Minutes: " + minutes);
        System.out.println("Hours: " + hours);
        System.out.println("Days: " + days);
        System.out.println("Weeks: " + weeks);
        System.out.println("Years: " + years);
        

    }
    
}
