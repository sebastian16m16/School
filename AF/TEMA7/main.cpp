#include "Profiler.h"
#include "Queue.h"

enum { NOT_VISITED, VISITED};

typedef struct {
    int n;
    int *t;
    int *liste;
} Graf;

Graf * createGraf(int * nods, int *b, int nrOfNodes){
    Graf * graf = (Graf*)malloc(nrOfNodes * sizeof(Graf));
    for(int i=0; i<nrOfNodes; i++){

    }
}

void bfs(const int nodes, int root){
    int visitedNodes[nodes];
    Queue *queue = initQueue(queue);
    int i, v, w;

    for(i = 0 ; i < nodes; i++){
        visitedNodes[i] = NOT_VISITED;
    }
    visitedNodes[root] = VISITED;
    enqueue(queue, root);

    while(!queueEmpty(queue)){
        v = dequeue(queue)->Key;
    }
}

int main() {

    /*               TRY QUEUE             */
//    Queue *queue = initQueue(queue);
//    int arr[5] = {10, 5, 6, 5, 9};
//
//    for(int i=0; i<5; i++){
//        enqueue(queue, arr[i]);
//    }
//    printQueue(queue);
//    printf("Queue size: %d", queueSIZE(queue));
//
//    dequeue(queue);
//    printQueue(queue);
//    printf("Queue size: %d", queueSIZE(queue));
//    dequeue(queue);
//    printQueue(queue);
//    printf("Queue size: %d", queueSIZE(queue));


    return 0;
}