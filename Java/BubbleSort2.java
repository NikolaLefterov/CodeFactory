
import java.util.Scanner;
import java.util.Arrays;

public class BubbleSort2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        String words;
        System.out.print("Word: ");
        words = s.next();
        char[] wordsAsArrayOfChars = words.toCharArray();
        Arrays.sort(wordsAsArrayOfChars);
        
        for(int i = 0;i < words.length();i++){
            System.out.print(wordsAsArrayOfChars[i]);
                }
        System.out.println();
            }
                
        }

