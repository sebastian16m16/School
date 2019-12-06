#include "Profiler.h"
const int n = 10000;

Profiler chart("Chart BTS");

typedef struct branch{
    struct branch *left{};
    struct branch *right{};
    int size = 1;
    int data {};
}Branch;
Branch * initializeBranch(Branch *b1, int x);

Branch * createTree(int nrOfBranches, int * arr,int length, Operation comp, Operation assign){
    static int lowLimit = 0;
    Branch *tree;
    int nLeft, nRight;

    comp.count(1);
    if(nrOfBranches <= 0 ) return  nullptr;
    else{
        nLeft = nrOfBranches / 2;
        nRight = nrOfBranches - nLeft - 1;
        assign.count(2);
        tree = (Branch *) malloc (sizeof(Branch));

        comp.count(1);
        if(lowLimit == length)
            return tree;
        tree = initializeBranch(tree, arr[lowLimit++]);
        tree->left = createTree(nLeft, arr,length, comp, assign);
        tree->right = createTree(nRight, arr, length, comp, assign);
        tree->size += nLeft + nRight;
        assign.count(4);
    }
    return tree;
}

Branch* build(int * arr, int low, int high){
    if(low >= high) return nullptr;
    else{
        int m = (low + high)/2;

        Branch *tree;
        tree = (Branch *) malloc (sizeof(Branch));

        tree = initializeBranch(tree, arr[m]);
        tree->left = build(arr, low, m-1);
        tree->right =  build(arr, m+1, high);
        tree->size += high - low;

        return  tree;
    }
}

Branch *OS_Select(Branch * tree, int x, Operation comp, Operation assign){
    int rank = 1;
    //printf("%d - %d (%d)\r\n", x, tree->data, tree->left->size);
    if (tree->left)
        rank += tree->left->size;
    assign.count(1);
    comp.count(1);
    if(x == rank) {
        return tree;
    }else if(x < rank){
        return OS_Select(tree->left, x, comp, assign);
    }else{
        return OS_Select(tree->right, x - rank, comp, assign);
    }
}

Branch *addBranch(Branch *branch, Branch *tree){
    if(tree == nullptr){
        tree = (Branch*) malloc(sizeof(struct branch));
        tree = branch;
    }else if(branch->data < tree->data){
        addBranch(branch, tree->left);
    }else{
        addBranch(branch, tree->right);
    }
    return tree;
}

Branch *initializeBranch(Branch *b1, int x){
    b1->right = nullptr;
    b1->left = nullptr;
    b1->size = 1;
    b1->data = x;

    return b1;
}

void printTree(Branch * tree){
    if(tree != nullptr){
        printf("%d ", tree->data);
        printf(" Size - %d \n", tree->size);
        printTree(tree->left);
        printTree(tree->right);
    }
}


int getRandom(int minRange, int maxRange){
    return (rand() % (maxRange - minRange + 1)) + minRange;
}
int main() {
    //int arr[n];
    //FillRandomArray(arr, n, 1, 20, false, 0);
    //Branch *tree = createTree(n, arr, 0, n);

    /* ------------    TEST    ------------------------------*/
//        Operation assign = chart.createOperation("Assign", 20);
//        Operation comp = chart.createOperation("Comp", 20);
//
//
//    int number = 9;
//    int ex[20] = { 26, 17, 41, 14, 21, 30, 47, 10, 16, 19, 21, 28, 38, 7, 12, 14, 20, 35, 39, 3};
//    Branch *testRoot = createTree(20, ex, 20, comp, assign);
//    Branch * selected = OS_Select(testRoot, number, comp, assign);
//
//    printTree(testRoot);
//    printf("The %d'th smallest element is: %d\nWith Size: %d", number, selected->data, selected->size);



    /*     The real thing    */

    int arr[n];
    int foundElements = 0;
    for(int i=100; i<101; i+=100){
        Operation assign = chart.createOperation("Assign", i);
        Operation comp = chart.createOperation("Comp", i);
        Operation assignBuild = chart.createOperation("AssignBuild", i);
        Operation compBuild = chart.createOperation("CompBuild", i);

        FillRandomArray(arr, i, 1, 50000, true, 1);
        Branch *tree = build(arr, 0, i-1);
        printf("\n\nN = %d\n", i);
        printTree(tree);

        for(int j=1; j < i/2; j++){
            Branch *found = OS_Select(tree, getRandom(1, i/2), comp, assign);
            if(found != nullptr) foundElements++;
        }

        printf("Found %d elements!\n", foundElements);
    }

    chart.createGroup("OS_SELECT", "Assign", "Comp");
    chart.createGroup("Create_Tree", "AssignBuild", "CompBuild");
    chart.showReport();


    return 0;
}