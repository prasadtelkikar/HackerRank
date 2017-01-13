import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

// Used Arithmatic progression to Solve this Problem
public class Kangaroo  {
    
    //Wrote function to get n in the tn formula
    private int GetJumpCountByAP(int firstStartPointK1, int secondStartPointK2, int firstRateOfK1, int secondRateOfK2){
        int jumps = 0;
        if(((firstStartPointK1 - secondStartPointK2) % (firstRateOfK1 - secondRateOfK2)) == 0)
            jumps = ((firstStartPointK1 - secondStartPointK2) / (firstRateOfK1 - secondRateOfK2));
        else
            jumps = 0;
        
        return jumps;
    }
    
    //Get tn from Value
    private int GetnthTerm(int startPoint, int dist, int n){
        return (startPoint + ((n) * dist));
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int startPointOfK1 = in.nextInt();
        int rateOfK1 = in.nextInt();
        int startPointOfK2 = in.nextInt();
        int rateOfK2 = in.nextInt();
        int jumpCount = 0;
        
        Kangaroo kObj = new Kangaroo();
        
        //if second kangaroo is ahead of first kangaroo
        if(rateOfK1 == rateOfK2 && ((startPointOfK2 > startPointOfK1) || (startPointOfK2 == startPointOfK1)))
            System.out.println("NO");
        else{
            //Get the jump count 
            if(startPointOfK1 > startPointOfK2)
                jumpCount = kObj.GetJumpCountByAP(startPointOfK1, startPointOfK2, rateOfK2, rateOfK1);
            else
                jumpCount = kObj.GetJumpCountByAP(startPointOfK2, startPointOfK1, rateOfK1, rateOfK2);
            
            //Print result
            if(kObj.GetnthTerm(startPointOfK1, rateOfK1, jumpCount) == kObj.GetnthTerm(startPointOfK2, rateOfK2, jumpCount) && jumpCount >= 0)
                System.out.println("YES");
            else
                System.out.println("NO");
        }
    }
}
