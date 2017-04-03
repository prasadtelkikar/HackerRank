#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int ComparePointsForA(int countA,int countB,int results){
    if(countA > countB ){
        results++;
    }
    return results;
}
int ComparePointsForB(int countA,int countB,int results){
    if(countA < countB ){
        results++;
    }
    return results;
}
int main(){
    int a0; 
    int a1; 
    int a2; 
    scanf("%d %d %d",&a0,&a1,&a2);
    int b0; 
    int b1; 
    int b2,resultsForA =0, resultsForB =0,results =0; 
    scanf("%d %d %d",&b0,&b1,&b2);
    resultsForA = ComparePointsForA(a2,b2,ComparePointsForA(a1,b1,ComparePointsForA(a0,b0,results)));
    results =0;
    resultsForB = ComparePointsForB(a2,b2,ComparePointsForB(a1,b1,ComparePointsForB(a0,b0,results)));
    printf("%d %d",resultsForA, resultsForB);
    return 0;
}