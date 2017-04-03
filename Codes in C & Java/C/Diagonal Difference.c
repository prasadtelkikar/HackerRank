#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int main(){
    int n, result; 
    int sumFirstDiagonal = 0, sumSecondDiagonal = 0;
    scanf("%d",&n); //size of matrix
    int a[n][n];
    for(int a_i = 0; a_i < n; a_i++){
       for(int a_j = 0; a_j < n; a_j++){     
          scanf("%d",&a[a_i][a_j]); //read inputs from user
       }
    }
    
    for(int a_j = 0; a_j < n; a_j++){
        sumFirstDiagonal += a[a_j][a_j];   //Sum of elements of Primary Diagonal
        sumSecondDiagonal += a[a_j][n - a_j - 1];  //Sum of elements of Secondary Diagonal
    }
    result = abs(sumFirstDiagonal - sumSecondDiagonal);
    printf("%d", result);
    return 0;
}