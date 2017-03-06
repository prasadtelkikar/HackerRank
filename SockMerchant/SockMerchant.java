import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class SockMerchant{

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int arr[] = new int[n];
        for(int c_i=0; c_i < n; c_i++){
            arr[c_i] = in.nextInt();
        }
        
        Arrays.sort(arr);
        int[] frequency = new int[arr[n-1]+1];
        for(int i = 0; i < n; i++){
            ++frequency[arr[i]];
        }
        
        int count = 0;
        for(int j = 0; j < frequency.length; j++)
            if(frequency[j] != 0)
                count += (frequency[j]/2);
            
        System.out.println(count);
    }
}