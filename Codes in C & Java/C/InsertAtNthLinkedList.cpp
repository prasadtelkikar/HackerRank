#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
/* https://www.hackerrank.com/challenges/maximum-draws
	Insert node at nth position
	5
	3 0
	5 1
	4 2
	2 3
	10 1
*/


struct Node{
	int data;
	Node* next;
};

Node* CreateNode(Node* head, int data);
void Display(Node* head);
Node* InsertNth(Node* head, int data, int position);

int main(){
	int size = 0;
	int data = 0;
	int location = 0;
	Node* head = NULL;

	printf("\nEnter size: ");
	scanf("%d", &size);
	
	for (int i = 0; i < size; ++i)
	{
		scanf("%d%d", &data, &location);
		head = InsertNth(head, data, location);
	}
	Display(head);

	return 0;
}


Node* CreateNode(Node* head, int data){
	Node* temp =(Node*) malloc(sizeof(Node));
	temp -> data = data;
	temp -> next = NULL;

	if(head == NULL)
		head = temp;
	else{
		temp -> next = head;
		head = temp;
	}
	return head;
}

void Display(Node* head){
	if(head == NULL){
		printf("%s\n", "List is empty");
	}
	else{
		while(head != NULL){
			printf("%d\n", head -> data);
			head = head -> next;
		}
	}
}

Node * InsertNth(Node* head, int data, int position){
	Node* temp = (Node*) malloc(sizeof(Node));
	temp -> data = data;
	temp -> next = NULL;
	Node* currentNode = head;
	int currentPosition = 0;
	if(position == 0){
		temp -> next = head;
		head = temp;
		return head;
	}
	else{
		while(currentNode != NULL){
			currentPosition++;
			if(currentPosition == position){
				temp -> next = currentNode -> next;
				currentNode -> next = temp;
			}
			currentNode = currentNode -> next;
		}
	}
	return head;
}