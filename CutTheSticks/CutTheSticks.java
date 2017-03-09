import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class CutTheSticks {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int arr[] = new int[n];
        for(int arr_i=0; arr_i < n; arr_i++){
            arr[arr_i] = in.nextInt();
        }
        Arrays.sort(arr);
        
        int RemSticks = n, index = 0;
        
        while(RemSticks != 0){
            int temp = arr[index];
            System.out.println(RemSticks);
            for(int i = index; i < n; i++)
                arr[i] -= temp;
            
            for(int j = index; j < n; j++)
                    if(arr[j] == 0){
                      index++;
                      RemSticks --;
            }
        }
    }
}
