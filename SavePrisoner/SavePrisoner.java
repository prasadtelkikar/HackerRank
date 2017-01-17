import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        
        int testCaseCount = in.nextInt();
        
        for(int i = 0; i < testCaseCount; i++){
            long numberOfPrisoner = in.nextInt();
            long numberOfSweets = in.nextInt();
            long startPosition = in.nextInt();
            
            if((numberOfSweets + startPosition - 1) % numberOfPrisoner == 0)
                System.out.println(numberOfPrisoner);
            else
                System.out.println((numberOfSweets + startPosition - 1) % numberOfPrisoner);
        }
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
    }
}