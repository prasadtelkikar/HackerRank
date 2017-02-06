import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public boolean CheckForPrime(double n)
        {
        if(n == 2)
            return true;
        
        if(n % 2 == 0 || n <= 1)
            return false;
        
        long n1 = (long)Math.sqrt(n);
        for(int i = 3; i <= n1; i+=2)
            if(n % i == 0)
                return false;
            
        return true;
    }
    public static void main(String[] args) {
        /* Enter your code here. */
        int testCount = 0;
        int n;
        Solution s = new Solution();
        Scanner sn = new Scanner(System.in);
        testCount = sn.nextInt(); 
        while(testCount-- >0){
            boolean isPrime = s.CheckForPrime(sn.nextInt());
            if(isPrime)
                System.out.println("Prime");
            else
                System.out.println("Not prime");
        }
    }
}
