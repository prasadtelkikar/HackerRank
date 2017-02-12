/*Minimum Absolute Difference in an Array*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Problem2 {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] a = new int[n];
        int min = 0;
        
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        Arrays.sort(a);
        min = Math.abs(a[0] - a[1]);
        
        for(int i = 0; i < n - 1; i++){
            int result = Math.abs(a[i] - a[i+1]);
            if(min > result)
                min = result;
        }
        System.out.println(min);
        // your code goes here
    }
}