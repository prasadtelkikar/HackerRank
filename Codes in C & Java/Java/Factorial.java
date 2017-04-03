import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Factorial {
    public BigInteger FindFactorial(int n){
        BigInteger bigInt = new BigInteger("1");
        for(int i = 2; i <=n; i++)
            bigInt = bigInt.multiply(BigInteger.valueOf(i));
        return bigInt;
    }
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        Factorial F = new Factorial();
        System.out.println(F.FindFactorial(n));
    }
}
