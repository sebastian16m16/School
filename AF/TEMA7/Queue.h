#include "Profiler.h"

typedef struct Node{
    int Key;
    struct Node *next;
}Node;

typedef struct Queue{
    Node *front, *rear;
}Queue;

Queue* enqueue(Queue *queue,int k){
    Node * temp = (Node*)malloc(sizeof(Node));
    temp->Key = k;
    temp->next = nullptr;

    if(queue->front == nullptr){
        queue->front = queue->rear = temp;
    }else {
        queue->rear->next = temp;
        queue->rear = temp;
    }

    return queue;
}

Node *dequeue(Queue* queue){
    Node* ret = queue->front;
    queue->front = queue->front->next;
    return ret;
}

int queueSIZE(Queue* queue){
    Node * temp = queue->front;
    int size = 0;
    while(temp != nullptr){
        size++;
        temp = temp->next;
    }
    return size;
}

Queue *initQueue(Queue *queue){
    queue = (Queue*)malloc(sizeof(Queue));
    queue->front = nullptr;
    queue->rear = nullptr;

    return queue;
}

void printQueue(Queue *queue){
    Node *temp = queue->front;

    printf("\n");
    while(temp != nullptr){
        printf("%d ", temp->Key);
        temp = temp->next;
    }
    printf("\n");
}

int queueEmpty(Queue* queue){
    if(queue->front == nullptr) return 1;
    else
        return 0;
}

