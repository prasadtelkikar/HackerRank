import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class ReverseCal {
    //Reverse the given number
    private long GetReverseNumber(long number){
        long reverseNumber = 0;
        while(number != 0){
            long rem = number % 10;
            reverseNumber = reverseNumber * 10 + rem;
            number = number / 10;
        }
        return reverseNumber;
    }
    
    //Check numberator is wholly divisible by denominator where numberator is substracted value of originar number to reversed
    private boolean IsWholeNumber(long number, long reverseNumber, long denominator){
        boolean isBeautiful = false;
        long subAbs = Math.abs(number - reverseNumber);
        double div = subAbs / (double)denominator;
        return div % 1 == 0 ? true : false;
    }
    
    public static void main(String[] args) {
        
        Scanner in = new Scanner(System.in);
        long start = in.nextInt();
        long end = in.nextInt();
        long denominator = in.nextInt();
        long count = 0;
        ReverseCal RC = new ReverseCal();
        //Check for given range
        for(long i = start; i <= end; i++){    
            long rev = RC.GetReverseNumber(i);
            boolean isBeautiful = RC.IsWholeNumber(i, rev, denominator);
            //count if value is beautiful
            if(isBeautiful)
                count ++;
        }
        
        System.out.println(count);
    }
}