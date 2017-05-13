//#FunctionOnly: Cycle Detection
//https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle

/*
Detect a cycle in a linked list. Note that the head pointer may be 'NULL' if the list is empty.

A Node is defined as: 
    struct Node {
        int data;
        struct Node* next;
    }
*/

bool has_cycle(Node* head) {
    Node* slowNode = head;
    Node* fastNode = head;
    if(head == NULL)
        return false;
    else{
        while(fastNode != NULL && fastNode -> next != NULL){
            slowNode = slowNode -> next;
            fastNode = fastNode -> next -> next;
            if(slowNode == fastNode)
                return true;
        }    
        return false;
    }
}
