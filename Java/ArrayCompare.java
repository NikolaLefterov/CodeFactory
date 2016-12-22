
import java.util.Scanner;

public class Excel1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Text: ");
        String text = s.nextLine();
        System.out.print("Search: ");
        String search = s.nextLine();
        int pos = text.indexOf(search);
        if(pos == -1) {
            System.out.println("Not found");
            return;
        }
        while(pos >= 0) {
            System.out.printf("Position %d\n", pos);
            pos = text.indexOf(search, pos+1);
        }
        
        }
    }