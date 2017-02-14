import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class FindDigits {
    
    //Get digits from a number
    public ArrayList<Integer> GetDigits(int n){
        ArrayList<Integer> list = new ArrayList<Integer>();
        while(n!= 0){
            int rem = n % 10;
            n = n / 10;
            list.add(rem);
        }
        return list;
    }
    public static void main(String[] args) {
        
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        FindDigits FD = new FindDigits();
        
        for(int a0 = 0; a0 < t; a0++){
            int n = in.nextInt();
            int count = 0;
            ArrayList<Integer> digits = FD.GetDigits(n);
            for(Integer i : digits){
                if(i != 0 && n % i == 0)
                    count ++;
                }
            System.out.println(count);
            }
        }
    }