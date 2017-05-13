//Find Merge Point of two lists
//https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/editorial

/*
   Find merge point of two linked lists
   Node is defined as
   struct Node
   {
       int data;
       Node* next;
   }
*/

int FindMergeNode(Node *headA, Node *headB)
{
    int lengthHeadA = 0, lengthHeadB = 0;
    Node* currentHeadA = headA;
    Node* currentHeadB = headB;
    
    //Calculate Size of headA
    while(currentHeadA != NULL){
        currentHeadA = currentHeadA -> next;
        lengthHeadA ++;
    }
    
    //Calculate size of head2
    while(currentHeadB != NULL){
        currentHeadB = currentHeadB -> next;
        lengthHeadB ++;
    }
    //Calculate difference between 2 linked list
    int length = (lengthHeadA >= lengthHeadB) ? lengthHeadA - lengthHeadB : lengthHeadB - lengthHeadA;
    
    //Check which linked list is greater
    bool isFirstGreater = (lengthHeadA > lengthHeadB) ? true : false;
    
    currentHeadA = headA;
    currentHeadB = headB;
    
    //Make current Pointer at par
    if(isFirstGreater){
        while(length > 0){
            currentHeadA = currentHeadA -> next;
            length --;
        }    
    }
    else{
        while(length > 0){
            currentHeadB = currentHeadB -> next;
            length --;
        }
    }
    
    //Move both the linked list equally
    int isFound = 1;
    int result = 0;
    while(isFound){
        if(currentHeadA -> data == currentHeadB -> data){
           result = currentHeadA -> data;
           isFound = 0;
        }
        else{
            currentHeadA = currentHeadA -> next;
            currentHeadB = currentHeadB -> next;
        }
    }
    return result;
}