import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class consecutive1s {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int count = 0, maxCount = 0;
        
        String s = new String();
        String binaryValue = Integer.toBinaryString(n);
        
        char[] arrayBinary = binaryValue.toCharArray();
        for(int i = 0; i < binaryValue.length(); i++){
            if(arrayBinary[i] == '1'){
                count ++;
                if(count > maxCount)
                    maxCount = count;
                }
            else
                count = 0;
        }
        System.out.println(maxCount);
    }
}
