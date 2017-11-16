//#FunctionOnly: Merging of two sorted list
//https://www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem


/*
  Merge two sorted lists A and B as one linked list
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
Node* MergeLists(Node *headA, Node* headB)
{
  // This is a "method-only" submission. 
  // You only need to complete this method
    
    if(headA == NULL)
      return headB;
    
    if(headB == NULL)
        return headA;
    
    Node *head;
    if(headA -> data < headB -> data){
        head = headA;
    }
    else{
        head = headB;
        headB = headA;
        headA = head;
    }
    
    while(headA -> next != NULL){
        if(headA -> next -> data > headB -> data){
            Node *temp = headA -> next;
            headA -> next = headB;
            headB = temp;
        }
        headA = headA -> next;
    }
    headA -> next = headB;
    return head;
}
