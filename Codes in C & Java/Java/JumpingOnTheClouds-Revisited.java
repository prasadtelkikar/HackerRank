import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JumpingOnTheClouds-Revisited {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int k = in.nextInt();
        int c[] = new int[n];
        for(int c_i=0; c_i < n; c_i++){
            c[c_i] = in.nextInt();
        }
        int moveValue = 0, energy= 0;
        
       do{
           if(moveValue == (n - k))
               moveValue = 0;
           else
               moveValue += k;
           
           if(c[moveValue] == 1)
               energy +=2;
           
           energy++;
       }while(moveValue != 0);
       System.out.println(100 - energy);
    }
}
