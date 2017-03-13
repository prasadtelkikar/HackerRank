import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Candy {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int t = in.nextInt();
        int[] c = new int[t];
        for(int c_i=0; c_i < t; c_i++){
            c[c_i] = in.nextInt();
        }
        int result = 0;
        int tempN = n - c[0];;
        for(int i = 1; i < t -1; i++){
                tempN -= c[i];
            
                 if(tempN < 5){
                    int sub = (n - tempN);
                    result += sub;
                    tempN += sub;    
                     
                 }   
        }
        System.out.println(result);
    }
}