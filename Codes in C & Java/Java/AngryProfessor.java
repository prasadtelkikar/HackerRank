import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class AngryProfessor {
    
    //Get count of negative integers in an array.
    private int GetStudentCount(int arr[], int n){
        int count = 0;
        for(int i = 0; i < n; i++){
            if(arr[i] <= 0)
                count ++;
        }
        return count;
    }
    
    public static void main(String[] args) {
    
        Scanner in = new Scanner(System.in);
        AngryProfessor AP = new AngryProfessor();
        int testCaseCount = in.nextInt();
    
        for(int i = 0; i < testCaseCount; i++){
            int numberOfStudents = in.nextInt();
            int thresholdLimit = in.nextInt();
        
            int a[] = new int[numberOfStudents];
            for(int j = 0; j < numberOfStudents; j++){
                a[j] = in.nextInt();
            }
            
            int atteStudent = AP.GetStudentCount(a, numberOfStudents);
            
            //if negative integers are less than thresholdLimit then Class cancels.
            if(thresholdLimit > atteStudent)
                System.out.println("YES");
            else
                System.out.println("NO");
                
        }
    }
}
