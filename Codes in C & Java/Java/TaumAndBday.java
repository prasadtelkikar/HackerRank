import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class TaumAndBday {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        TaumAndBday s = new TaumAndBday();
        while(t-- > 0){
            long b = in.nextLong();
            long w = in.nextLong();
            long x = in.nextLong();
            long y = in.nextLong();
            long z = in.nextLong();
            
            System.out.println(s.FindTotal(b, w, s.FindSmallest(x, y, z), s.FindSmallest(y, x, z)));
            
        }
    }
    
     public long FindSmallest(long value, long xORy, long z){
         if(value > xORy && value > z && value > (xORy + z))
                 return (xORy + z);
         else
             return value;
     }
    
    public long FindTotal(long NW, long NB, long VW, long VB){
        return ((NW * VW) + (NB * VB));
    }
}
