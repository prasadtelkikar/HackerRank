import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JumpingClouds {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int c[] = new int[n];
        
        for(int c_i=0; c_i < n; c_i++){
            c[c_i] = in.nextInt();
        }
        
        int jumpCount = 0, current_pos = 0;
        
        while(current_pos < n -1){
            if(current_pos + 1 == n - 1){    //check for last jump
                    jumpCount++;
                    break;
            }
            if(c[current_pos + 2] != 1){    //check for i + 2 jump
                current_pos += 2;
                jumpCount++;
            }
            else{
                current_pos +=1;            //Check for i + 1 jump
                jumpCount++;
            }
        }
        System.out.println(jumpCount);
    }
}