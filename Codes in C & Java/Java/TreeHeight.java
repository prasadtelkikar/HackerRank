import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class TreeHeight {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        int initialHeight = 1;
        int[] arr = new int[t];
        for(int i = 0; i < t; i++){
            arr[i] = in.nextInt();
        }
        for(int i = 0; i < t; i++){
            int height = 0;
            if(arr[i] % 2 == 0)
                height =(int)((Math.pow(2, (arr[i] / 2)) - 1) * 2 + 1);
            else
                height =(int)((Math.pow(2, (arr[i] / 2 + 1)) - 1) * 2);
            System.out.println(height);
        }
    }
}
