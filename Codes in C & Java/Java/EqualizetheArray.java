import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class EqualizetheArray {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        int value = 0, n, max = 0;
        Scanner in = new Scanner(System.in);
        n = in.nextInt();
        int[] arr = new int[n];
        
        for(int i = 0; i < n; i++){
             arr[i] = in.nextInt();
        }
        
        Arrays.sort(arr);
        int temp = arr[n - 1];
        
        int[] count = new int[temp+1];
        for(int j = 0; j < n; j++){
            if(arr[j] != 0)
                ++count[arr[j]];
        }
        
        Arrays.sort(count);
        System.out.println(n - count[temp]);
        
    }
    
}