/*HackerRank in a String!*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Problem3 {
    public boolean CheckForHR(String str){
        boolean isAvailable = false;
        int[] indexOfHR = new int[10];
        indexOfHR[0] = str.indexOf("h");
        indexOfHR[1] = str.indexOf("a",indexOfHR[0] + 1);
        indexOfHR[2] = str.indexOf("c",indexOfHR[1] + 1);
        indexOfHR[3] = str.indexOf("k",indexOfHR[2] + 1);
        indexOfHR[4] = str.indexOf("e",indexOfHR[3] + 1);
        indexOfHR[5] = str.indexOf("r",indexOfHR[4] + 1);
        indexOfHR[6] = str.indexOf("r", indexOfHR[5] + 1);
        indexOfHR[7] = str.indexOf("a", indexOfHR[6] + 1);
        indexOfHR[8] = str.indexOf("n",indexOfHR[7] + 1);
        indexOfHR[9] = str.indexOf("k", indexOfHR[8] + 1);
        if(Arrays.asList(indexOfHR).contains(-1))
            return false;
        else
            {
            for(int i = 0; i < 10; i++){
                for(int j = 1 + i; j < 10; j++){
                    //System.out.println(indexOfHR[i]+"\t"+indexOfHR[j]);
                    if(indexOfHR[i] > indexOfHR[j])
                        return false;
                }
            }
        }
        return true;
    }
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for(int a0 = 0; a0 < q; a0++){
            String s = in.next();
            // your code goes here
            Solution s1 = new Solution();
            boolean isHR = s1.CheckForHR(s);
            if(isHR)
                System.out.println("YES");
            else
                System.out.println("NO");
        }
    }
}
