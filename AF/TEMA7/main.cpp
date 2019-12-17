#include "Profiler.h"
#include "Queue.h"

enum { NOT_VISITED, VISITED};

typedef struct {
    int n;
    Node **t;
} Graf;

Graf * createGraf(int * nods, int *b, int nrOfNodes){
    Graf * graf = (Graf*)malloc(nrOfNodes * sizeof(Graf));
    for(int i=0; i<nrOfNodes; i++){

    }
}

void bfs(Graf G, int nodSursa)
{
    int* vizitate; /* pentru marcarea nodurilor vizitate */
    vizitate = calloc(G.n, sizeof(int));
    if (vizitate == NULL) printErr();

    Queue* Q = initQueue(Q); /* coada nodurilor - intregi */

    int i, v, w; /* noduri */


    for (i = 0; i < G.n; i++) /* marcam toate nodurile ca nevizitate */
        vizitate[i] = NOT_VISITED;
    vizitate[nodSursa] = VISITED; /* marcam nodul sursa ca vizitat */

//	procesam informatia pt nodSursa;
    printf("%d ", nodSursa);
    enqueue( Q, nodSursa );
    // nodSursa va fi primul nod scos din coada
    while( ! queueEmpty( Q ))
    {
        v = dequeue( Q );
        Node* p = G.t[v];
        while (p != NULL) {
            w = p->Key;
            if (vizitate[w] == NOT_VISITED)
            {
                vizitate[w] = VISITED;
                //procesam informatia pt w;
                printf("%d ", w);
                enqueue(Q, w);
            }
            p = p->next;
        }
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