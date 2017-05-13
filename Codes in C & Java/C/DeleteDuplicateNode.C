// Delete duplicate-value nodes from a sorted linked list
//https://www.hackerrank.com/challenges/delete-duplicate-value-nodes-from-a-sorted-linked-list
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
/*Sample Input 0:
 * 6
 * 1 2 2 3 3 4
 * 7
 * 1 1 1 1 1 1 1
 * 5
 * 2 3 3 4 6
 * 1
 * 10
 * Sample Output 0:
 * 1 2 3 4
 * 1
 * 2 3 4 6
 * 10
*/
struct Node{
	int data;
	struct Node* next;
};

Node* CreateList(Node* head, int value);
void Display(Node* head);
Node* DeleteDuplicate(Node* head);

int main(){
	int size;
	int value = 0;
	Node* head = NULL;

	printf("%s\n", "Enter size of linked list:");
	scanf("%d", &size);

	for (int i = 0; i < size; ++i)
	{
		printf("\nEnter Value: ");
		scanf("%d", &value);
		head = CreateList(head, value);
	}
	printf("\n%s", "Original List: \n\t");
	Display(head);
	DeleteDuplicate(head);
	printf("\n%s", "List Containing unique values: \n\t");
	Display(head);
}

// Insert node at the end of list
Node* CreateList(Node* head, int value){
	Node* temp = (Node*) malloc(sizeof(Node));
	temp -> data = value;
	temp -> next = NULL;
	Node* currentNode = head;

	if(head == NULL)
		head = temp;
	else{
		while(currentNode -> next != NULL)
			currentNode = currentNode -> next;

		currentNode -> next = temp;
	}
	return head;
}

//Display list
void Display(Node* head){
	printf("\n");

	if(head == NULL)
		printf("\n%s", "List is empty");
	else{
		while(head != NULL){
			printf("%d\t", head -> data);
			head = head -> next;
		}
	}
}

//Delete duplicate node from list
Node* DeleteDuplicate(Node* head){
	int swapped = 0;
	if(head == NULL)
		return head;
	else{
		do{
			Node* currentNode = head;
			Node* nextNode = NULL;
			Node* previousNode = head;
			swapped = 0;
			while(currentNode != NULL && currentNode -> next != NULL){
				nextNode = currentNode -> next;
				if(nextNode -> data == currentNode -> data){
					nextNode = nextNode -> next;
					currentNode -> next = nextNode;

					previousNode = currentNode;
					currentNode = nextNode;
					swapped = 1;
				}
				else{
					previousNode = currentNode;
					currentNode = nextNode;
				}
			}
		}while(swapped);

	}
	return head;
}