#include "Queue.h"
#include "Stack.h"

enum { NOT_VISITED, VISITED };
enum { WHITE, GRAY, BLACK };
typedef struct {
    int n;
    Node **t;
} Graf;
typedef struct {
    int n;      // numar de varfuri
    Stack** t;  // tabloul de liste (va fi alocat dinamic)
    int* pi; //vectorul de parinti
    int* d; //timpii de descoperire
    int* f; //timpii de finalizare
    int* color; //informatia de culoare
} Graf2;
void printErr() {
    printf("Memorie insuficienta!\n");
    exit(1);
}

void insereaza(int w, int v, Graf* pG) {
    Node* elem = (Node*)malloc(sizeof(Node));

    elem->Key = w;
    elem->next = pG->t[v];
    pG->t[v] = elem; //insert first
}

Graf * createGraf(int * nods, int *b, int nrOfNodes, Graf * G){
    G->n = nrOfNodes;
    G->t = (Node **) calloc(G->n, sizeof(Node *));
    if(G->t == nullptr) printErr();

    for(int i=0; i < G->n; i++){
        G->t[i] = NULL;
    }

    for(int i = 0; i<nrOfNodes; i++){

        insereaza(nods[i], b[i], G);
        insereaza(b[i], nods[i], G);
        printf("%d %d \n", nods[i], b[i]);
    }
}

void bfs(Graf G, int root, Operation comp, Operation assign){
    int * visited =(int*) calloc(G.n, sizeof(int));

    if(visited == nullptr) printErr();
    int v, w;
    Queue * Q = initQueue(Q);

    for(int i= 0; i<G.n; i++){
        visited[i] = NOT_VISITED;
    }
    visited[root] = VISITED;

    //printf("%d ", root);
    enqueue(Q, root);
    assign.count(1);

    while(!queueEmpty(Q)){
        v = dequeue(Q);
        assign.count(2);
        Node * p = G.t[v];

        while(p != nullptr){
            comp.count(1);
            w = p->Key;
            assign.count(1);

            if(visited[w] == NOT_VISITED){
                visited[w] = VISITED;
                //printf("%d ", w);
                enqueue(Q, w);
                assign.count(1);
            }
            p=p->next;
        }
    }
}

void dfs(Graf2* G, int start)
{
    Stack* S;
    initStack(&S);
    push(&S, start);

    while (!empty(S)) {
        int v = pop(&S);
        if (G->color[v] == WHITE) {
            G->color[v] = GRAY;
            printf("%d ", v);
            Stack* p = G->t[v];
            while (p != nullptr) {
                int w = p->Key;
                if (G->color[w] == WHITE) {
                    push(&S, w);
                    G->pi[w] = v;
                }
                p = p->next;
            }
        }
    }
}

int getRandom(int minRange, int maxRange){
    return (rand() % (maxRange - minRange + 1)) + minRange;
}

int lookInGraf(Graf * G, int a, int b, int nrOfNodes){
    for(int i=0; i<nrOfNodes; i++){
        if(G->t[i] == nullptr) continue;
        //printf("t[%d] = %d \n", i, G->t[i]->Key);
        if(i == a){
            Node* p = G->t[i];
            while(p != nullptr){
                if(p->Key == b){
                    return 1;
                }
                p = p->next;
            }
            return 0;
        }
    }
    return 0;
}

int lookInGraf2(Graf2 * G, int a, int b, int nrOfNodes){
    for(int i=0; i<nrOfNodes; i++){
        if(G->t[i] == nullptr) continue;
        //printf("t[%d] = %d \n", i, G->t[i]->Key);
        if(i == a){
            Stack* p = G->t[i];
            while(p != nullptr){
                if(p->Key == b){
                    return 1;
                }
                p = p->next;
            }
            return 0;
        }
    }
    return 0;
}

void createGrafRight(int * arr, int numberOfKeys, int nOfLinks, Graf *G){
    int random = 0;
    int random2 = 0;
    int inserted = 0;

    G->n = numberOfKeys;
    G->t = (Node **) calloc(G->n, sizeof(Node *));
    if(G->t == nullptr) printErr();

    for(int i=0; i < G->n; i++){
        G->t[i] = nullptr;
    }

    for(int i = 0; i<nOfLinks; i++){
        inserted = 0;
        while(inserted == 0) {
            random = getRandom(0, numberOfKeys-1);
            random2 = getRandom(0, numberOfKeys-1);

            if (random != random2 && !lookInGraf(G, arr[random], arr[random2], numberOfKeys)) {
                insereaza(arr[random], arr[random2], G);
                insereaza(arr[random2], arr[random], G);
                //printf("%d %d \n", arr[random], arr[random2]);
                inserted = 1;
            }
        }
    }
}

void createGraf2(Graf2 * pG, int numberOfKeys, int * arr, int arrLength) {

    pG->n = numberOfKeys;  // citeste nr. de varfuri

    pG->t = (Stack **)calloc(pG->n, sizeof(Stack*));
    if (pG->t == nullptr) printErr();  // alocare esuata

    pG->pi = (int*)calloc(pG->n, sizeof(int));
    pG->d = (int*)calloc(pG->n, sizeof(int));
    pG->f = (int*)calloc(pG->n, sizeof(int));
    pG->color = (int*)calloc(pG->n, sizeof(int));

    int i;
    for (i = 0; i < pG->n; i++) {
        pG->t[i] = nullptr;
        pG->pi[i] = -1;
    }

    int v, w;
    int inserted = 0;
    for(int i=0; i<arrLength; i++){
        inserted = 0;
        while(inserted == 0){
            v = getRandom(0, numberOfKeys-1);
            w = getRandom(0, numberOfKeys-1);

            if (v != w && !lookInGraf2(pG, arr[v], arr[w], numberOfKeys)) {
                push(&pG->t[w], v);
                push(&pG->t[v], w);
                //printf("%d %d \n", arr[v], arr[w]);
                inserted = 1;
            }
        }
    }
}

void print(int* arr, int n)
{
    for (int i = 0; i < n; i++)
        printf("%d ", arr[i]);
    printf("\n");
}

void printGraf(Graf * G){
    for(int i=0; i<G->n; i++){
        if(G->t[i] == nullptr) continue;
        Node * p = G->t[i];
        while(p != nullptr){
            printf("%d %d\n", i, p->Key);
            p = p->next;
        }
    }
}

void printGraf2(Graf2 * G){
    for(int i=0; i<G->n; i++){
        if(G->t[i] == nullptr) continue;
        Stack * p = G->t[i];
        while(p != nullptr){
            printf("%d %d\n", i, p->Key);
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


/*          TEST    BFS        */
//    const int n = 7;
//    int  a[n] = {0,0,0,1,2,5,5};
//    int b[n] = {1,2,3,3,5,4,6};
//
//    Graf G;
//    createGraf(a, b, n, &G);
//    bfs(G, 0);

/*         Implement         */

//      Test 1
//    const int n = 10;
//
//    int a[n], b[n];
//    int min = 1;
//    int max = 10;
//    FillRandomArray(a, n, min, max, false, 1);
//    getLiked(a, b, n, min, max);
//
//    Graf G;
//    createGraf(a, b, n, &G);
//    bfs(G, min);

    Profiler profiler("MAIN");

    const int n = 10;
    const int numberOfLinks = 10;
    int a[n];
    int min = 0;
    int max = 9;
    Graf G;

    FillRandomArray(a, n, min, n-1, true, 1);

//    Operation comp1 = profiler.createOperation("comp_1_BFS", n);
//    Operation assign1 = profiler.createOperation("assign_1_BFS", n);
//
//    Operation comp2 = profiler.createOperation("comp_2_BFS", n);
//    Operation assign2 = profiler.createOperation("assign_2_BFS", n);
//    printf("The array is : ");
//    print(a, n);
//    createGrafRight(a, n, numberOfLinks, &G);
//    bfs(G, getRandom(min, n-1), comp1, assign1);
//    printGraf(&G);
//
            //    Operation comp1 = profiler.createOperation("comp_1_BFS", n);
            //    Operation assign1 = profiler.createOperation("assign_1_BFS", n);
            //
            //    Operation comp2 = profiler.createOperation("comp_2_BFS", n);
            //    Operation assign2 = profiler.createOperation("assign_2_BFS", n);
            //
            //    for(int i=1000; i<5000; i += 100){
            //        createGrafRight(a, 100, i, &G);
            //        bfs(G, getRandom(min, 99), comp1, assign1);
//    BFS   //    }
            //
            //    for(int i=100; i<200; i+=10){
            //        FillRandomArray(a, i, min, i-1, true, 1);
            //        createGrafRight(a, i, numberOfLinks, &G);
            //        bfs(G, getRandom(min, i-1), comp2, assign2);
            //    }
            //
            //
            //    profiler.createGroup("No.1", "comp_1_BFS", "assign_1_BFS");
            //    profiler.createGroup("No.2", "comp_2_BFS", "assign_2_BFS");
            //
            //    profiler.showReport();

  /*            DFS             */

    Graf2 G2;
    createGraf2(&G2, n, a, n);
    printGraf2(&G2);
    return 0;
}