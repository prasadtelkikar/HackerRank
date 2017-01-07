#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>
# define SIZE 5     

//Addition of an elements by skipping one element present at skipped_index
int Addition(long int arr[SIZE], int skipped_index){
    int sum;
    for(int i = 0; i < SIZE; i++){
        if(skipped_index == i)
            continue;
        
        sum += arr[i];
    }
    return sum;
}

//Find minimum number from an array 
int MinNumber(int sum[SIZE]){
    int minNumber = sum[0];
    
    for(int i = 1; i < SIZE; i++){
        if(minNumber > sum[i])
            minNumber = sum[i];
    }
    
    return minNumber;
}

//Find maximum number from an array
int MaxNumber(int sum[SIZE]){
    int maxNumber = sum[0];
    
    for(int i = 1; i < SIZE; i++){
        if(maxNumber < sum[i])
            maxNumber = sum[i];
    }
    
    return maxNumber;
}

int main(){
    long int arr[SIZE];
    int sum[SIZE];
    
    for(int i = 0; i < SIZE; i++){
        scanf("%ld ",&arr[i]);    
    }
    
    for(int j = 0; j < SIZE; j++){
        sum[j] = Addition(arr, j); 
    }
    
    int min = MinNumber(sum);
    int max = MaxNumber(sum);
    
    printf("%d %d", min, max);
    return 0;
}
