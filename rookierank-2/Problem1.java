/*Migratory Birds*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Problem1 {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] types = new int[n];
        int countOf1 = 0, countOf2 = 0, countOf3 = 0, countOf4 = 0, countOf5 = 0;
        for(int types_i=0; types_i < n; types_i++){
            types[types_i] = in.nextInt();
            switch(types[types_i])
                {
                case 1:
                    countOf1++;
                break;
                case 2:
                    countOf2++;
                break;
                case 3:
                    countOf3++;
                break;
                case 4:
                    countOf4++;
                break;
                case 5:
                    countOf5++;
                break; 
            }
        }
        
        if(countOf1 >= countOf2 && countOf1 >= countOf3 && countOf1 >= countOf4  && countOf1 >= countOf5)
            System.out.println("1");
        else if(countOf2 >= countOf1 && countOf2 >= countOf3 && countOf2 >= countOf4  && countOf2 >= countOf5)
            System.out.println("2");
        else if(countOf3 >= countOf1 && countOf3 >= countOf2 && countOf3 >= countOf4  && countOf3 >= countOf5)
            System.out.println("3");
        else if(countOf4 >= countOf1 && countOf4 >= countOf2 && countOf4 >= countOf3  && countOf4 >= countOf5)
            System.out.println("4");
        else 
            System.out.println("5");

        // your code goes here
    }
}