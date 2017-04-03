#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

//Get the location of fruit on x-axis
int * GetLocation(int *arr, int treeLocation, int numberOfFruits){
    int *temp = malloc(sizeof(int) * numberOfFruits);
    for(int i =0; i < numberOfFruits; i++){
        *(temp + i) = treeLocation + *(arr + i) ;
    }
    return temp;
}

//Number of fruits falls in the given range
int GetCount(int *arr, int numberOfFruits, int startPoint, int endPoint){
    int count = 0;
   
    for(int i =0; i < numberOfFruits; i++){
        if(*(arr + i) >= startPoint && *(arr + i) <= endPoint)
            count++;
    }    
    return count;
}

int main(){
    int s, t;  //startPoint(s) and endPoint(t) of house on x-axis
    scanf("%d %d",&s,&t);
    int a, b; //position of Apple tree(a) and orange tree(b) on x-axis
    scanf("%d %d",&a,&b);
    int m, n; // Number of fruits Apple(m) and Orange(n)
    scanf("%d %d",&m,&n);
    
    int *apple = malloc(sizeof(int) * m);  //location of each apple
    for(int apple_i = 0; apple_i < m; apple_i++){
       scanf("%d",&apple[apple_i]);
    }
    int *orange = malloc(sizeof(int) * n);  //Location of each orange
    for(int orange_i = 0; orange_i < n; orange_i++){
       scanf("%d",&orange[orange_i]);
    }
    
    int *arrOfApple = GetLocation(apple, a, m);     //Get calculated position of apple
    int *arrOfOrange = GetLocation(orange, b, n);   //Get calculate position of orange
    
    printf("%d", GetCount(arrOfApple, m, s, t));  //get count of apples comes under given range and print
    printf("\n%d", GetCount(arrOfOrange, n, s, t));  //get count of orange comes under given range and print
    
    return 0;
}
