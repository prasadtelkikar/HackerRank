import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Set {
    //Get GCD from two elements
    private int GetGCD(int a, int b){
        if(a == 0 || b == 0)
            return a+b;
        else
            {
            //System.out.println(a%b);
           return GetGCD(b, a%b);
        }
    }
    
    //Get LCM from array
    private int GetLCM(int arr[], int n){
        int ans = arr[0];
        if(n == 1){
            return ans;
        }
        else{
            for (int i=1; i<n; i++)
             ans = (((arr[i]*ans)) / (GetGCD(arr[i], ans)));
        }
        return ans;
    }
    
    //Count the number of multiples of LCM that evenly divides the GCD.
    private int GetCountOfElementBtnSets(int gcd, int lcm){
        int count = 0;
        for(int i = 1; i <=gcd; i++){
            if((gcd % (lcm * i)) == 0)
                count ++;
        }
        return count;
    }
    
    public static void main(String[] args) {
        Set setObj = new Set();
        int gcd = 1;
        Scanner in = new Scanner(System.in);
        int n = in.nextInt(); //size of set one
        int m = in.nextInt(); //size of set two
       
        //first set
        int[] a = new int[n];
        for(int i = 0; i < n; i++){
            a[i] = in.nextInt();
        }
        
        //second set
        int[] b = new int[m];
        for(int i = 0; i < m; i++){
            b[i] = in.nextInt();
        }
        
        //get gcd from second array
        for(int i = 0; i < m; i++){
            if(i == 0 && m == 1)
                gcd = b[0];
            else if(i == 0 && m != 1)
                gcd = setObj.GetGCD(b[0], b[1]);
            else
                gcd = setObj.GetGCD(gcd, b[i]);
        }
        
        //get lcm of first array
        int lcm = setObj.GetLCM(a, a.length);
        
        // count of multiples of lcm to gcd
        int countMultiple = setObj.GetCountOfElementBtnSets(gcd, lcm);
        
        System.out.println(countMultiple);     
    }
}
