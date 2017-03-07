import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class SqEquation {
    public static void main(String args[] ) throws Exception {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] arr = new int[n+1];
        HashMap<Integer, Integer> hashMap = new HashMap<Integer, Integer>();
        
        for(int i = 1; i <= n; i++){
            hashMap.put(in.nextInt(), i);
        }
        
        for(int k = 1; k <=n; k++){
            System.out.println(hashMap.get(hashMap.get(k)));
        }
    }
}
