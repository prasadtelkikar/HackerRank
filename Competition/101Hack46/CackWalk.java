import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.util.Collections;
public class CackWalk {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int temp = 0;
        int[] calories = new int[n];
        for(int calories_i=0; calories_i < n; calories_i++){
            calories[calories_i] = in.nextInt();
        }
        long walkDist = 0;
        Arrays.sort(calories);
        for(int i =0; i < calories.length; i++){
            walkDist += (calories[n-1-i] * Math.pow(2, i));
        }
        System.out.println(walkDist);
    }
}