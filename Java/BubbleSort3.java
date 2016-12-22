
package bg.unwe;
import java.util.Scanner;

public class BubbleSort3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      Scanner s = new Scanner(System.in);
      String sentence;
      System.out.print("Sentence: ");
      sentence = s.nextLine();
      String[] words = sentence.split(" ");
      boolean finished = false;
      int offset = 0;
        while(!finished){
            finished = true;
            offset++;
            for(int i = 0; i < words.length - offset;i++){
                if(words[i].compareToIgnoreCase(words[i+1]) > 0){
                    finished = false;
                    String temp = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = temp;
                }
            }
        }
        for(int i = 0; i < words.length;i++){
            System.out.printf("%s", words[i]);
            if(i<words.length-1){
                System.out.print(" ");
            }
            
                    
                    
                }
                    System.out.println();
                }
}
