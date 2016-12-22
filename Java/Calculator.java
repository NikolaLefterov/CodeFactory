

import java.util.Scanner;


public class Calculator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner (System.in);
        int num1;
        int num2;
       String operation;
       System.out.println("First number:");
       num1 = s.nextInt();
       System.out.println("Second number:");
       num2 = s.nextInt();
       Scanner op = new Scanner(System.in);

    System.out.println("Operator");
    operation = op.next();
       if (operation.equals("+"))
    {
        System.out.println("Result: "+(num1 + num2));
    }
    else if (operation.equals("-"))
    {
        System.out.println("Result: "+(num1 - num2));
    }       
    else if (operation.equals("*"))
    {
        System.out.println("Result: "+(num1 * num2));
    }   
    else if (operation.equals("/"))
    {
        if(num2==0){
            System.out.println("Division by zero is not allowed");
        }
        else
        System.out.println("Result: "+(num1 / num2));
    }
        else if (operation.equals("%"))
    {
        System.out.println("Result: "+(num1 % num2));
    }
          else if (operation.equals("#"))
    {
        System.out.println("This operator is not supported");
    }
        
    }
    
}
