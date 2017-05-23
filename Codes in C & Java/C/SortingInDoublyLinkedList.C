#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

struct Node{
	int data;
	Node* next;
	Node* prev;
};

Node* SortedInsert(Node* head, int data);
void Display(Node* head);

int main(){
	Node* head = NULL;

	head = SortedInsert(head, 6);
	head = SortedInsert(head, 4);
	head = SortedInsert(head, 5);
	head = SortedInsert(head, 2);
	head = SortedInsert(head, 1);
	head = SortedInsert(head, 3);
	//head = SortedInsert(head, 9);
	//head = SortedInsert(head, 10);
	Display(head);
}

Node* SortedInsert(Node* head, int data){

	Node* currentNode = head;
	Node* temp = (Node*) malloc(sizeof(Node));
	temp -> data = data;
	temp -> next = NULL;
	temp -> prev = NULL;

	if(head == NULL)
		head = temp;
	else{
		while(currentNode != NULL){
			if(currentNode -> data > temp -> data && currentNode -> prev == NULL){		
				temp -> next = currentNode;
				currentNode -> prev = temp;
				head = temp;
				break;
			}
			else if(currentNode -> data < temp -> data && currentNode -> next == NULL){
				temp -> prev = currentNode;
				currentNode -> 	next = temp;
				break;
			}
			else if(currentNode -> data < temp -> data && currentNode -> next -> data > temp -> data)
			{
				temp -> next = currentNode -> next;
				temp -> prev = currentNode;
				currentNode -> next -> prev = temp;
				currentNode -> next = temp;
				break;
			}
			currentNode = currentNode -> next;
		}
	}
	return head;
}

void Display(Node* head){
	while(head != NULL){
		printf("%d\n", head -> data);
		head = head -> next;
	}
}