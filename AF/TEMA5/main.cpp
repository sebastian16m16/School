#include "Profiler.h"
const int n = 10;


typedef struct branch{
    struct branch *left;
    struct branch *right;
    int size = 1;
    int data;
}Branch;
Branch * initializeBranch(Branch *b1, int x);

Branch * createTree(int nrOfBranches, int * arr, int lowLimit, int length){

    Branch *tree;
    int nLeft, nRight;

    if(nrOfBranches <= 0 ) return  NULL;
    else{


        nLeft = nrOfBranches / 2;
        nRight = nrOfBranches - nLeft - 1;
        tree = (Branch *) malloc (sizeof(Branch));
        tree = initializeBranch(tree, arr[lowLimit++]);
        if(lowLimit == length)
            return tree;
        tree->left = createTree(nLeft, arr, lowLimit, length);
        tree->right = createTree(nRight, arr, lowLimit, length);
        tree->size += nLeft + nRight;
    }
    return tree;
}

Branch *addBranch(Branch *branch, Branch *tree){
    if(tree == NULL){
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
    b1->right = NULL;
    b1->left = NULL;
    b1->size = 1;
    b1->data = x;

    return b1;
}

void printTree(Branch * tree){
    if(tree != NULL){
        printf("%d ", tree->data);
        printf(" Size - %d \n", tree->size);
        printTree(tree->left);
        printTree(tree->right);
    }
}
int main() {
    int arr[n];
    FillRandomArray(arr, n, 1, 20, false, 0);
    Branch *tree = createTree(n, arr, 0, n);;

    printTree(tree);
    return 0;
}