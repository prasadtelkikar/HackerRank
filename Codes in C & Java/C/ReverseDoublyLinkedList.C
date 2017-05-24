#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

struct Node{
	int data;
	Node* next;
	Node* prev;
};

Node* Reverse(Node* head);
Node* Insert(Node* head, int data);
void Display(Node* head);

int main(){
	int size;
	printf("\nEnter size: ");
	scanf("%d", &size);
	Node* head = NULL;
	int data = 0;
	for (int i = 0; i < size; ++i)
	{
		printf("\nEnter value: ");
		scanf("%d", &data);
		head = Insert(head, data);
	}
	head = Reverse(head);
	
	Display(head);
	return 0;
}

Node* Insert(Node* head, int data){
	Node* temp = (Node*) malloc(sizeof(Node));
	temp -> data = data;
	temp -> next = NULL;
	temp -> prev = NULL;
	Node* currentNode = head;
	if(head == NULL)
		return temp;
	else{
		while(currentNode -> next != NULL)
			currentNode = currentNode -> next;

		currentNode -> next = temp;
		temp -> prev = currentNode;
	}
	return head;
}

void Display(Node* head){
	for (Node* currentNode = head; currentNode != NULL; currentNode = currentNode -> next)
		printf("\n%d", currentNode -> data);
}

Node* Reverse(Node* head){
	Node* temp = NULL;
	Node* currentNode = head;
	if(head == NULL)
		printf("\nEmpty DLL");
	else{
		while(currentNode != NULL){
			temp = currentNode -> prev;
			currentNode -> prev = currentNode -> next;
			currentNode -> next = temp;

			currentNode = currentNode -> prev;
		}
	}
	head = temp -> prev;
}