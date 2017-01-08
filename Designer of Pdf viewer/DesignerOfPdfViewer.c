#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int GetMaxHeight(char * word, int *h){
    int maxHeight = 0, count = 0;  
    int index[10];
    while (*word){
        index[count] = *word - 'a' + 1;  //Get position of alphabet in A to Z
        count ++; word++;
    }
    maxHeight = h[index[0] - 1];
    
    for(int i = 1; i < count; i++){     //find max width
        if(maxHeight < h[index[i] - 1])
            maxHeight = h[index[i] - 1];
    }
    return maxHeight;
}

int main(){
    int n = 26;
    int *h = malloc(sizeof(int) * n);
    
    for(int h_i = 0; h_i < n; h_i++){
       scanf("%d",&h[h_i]);
    }
    
    char* word = (char *)malloc(512000 * sizeof(char));
    scanf("%s",  word);
    
    int maxHeight = GetMaxHeight(word, h);    //Funtion to get maximum height of a letter 
    int lengthOfWords = strlen(word);        //width of letters
    
    printf("%d", maxHeight * lengthOfWords); //area = height * width
    return 0;
}
