#include "Profiler.h"
const int n = 10;


typedef struct branch{
    struct branch *left{};
    struct branch *right{};
    int size = 1;
    int data {};
}Branch;
Branch * initializeBranch(Branch *b1, int x);

Branch * createTree(int nrOfBranches, int * arr,int length){
    static int lowLimit = 0;
    Branch *tree;
    int nLeft, nRight;

    if(nrOfBranches <= 0 ) return  nullptr;
    else{
        nLeft = nrOfBranches / 2;
        nRight = nrOfBranches - nLeft - 1;
        tree = (Branch *) malloc (sizeof(Branch));
        if(lowLimit == length)
            return tree;
        tree = initializeBranch(tree, arr[lowLimit++]);

        tree->left = createTree(nLeft, arr,length);
        tree->right = createTree(nRight, arr, length);
        tree->size += nLeft + nRight;
    }
    return tree;
}

Branch *OS_Select(Branch * tree, int x){
    int rank = tree->left->size + 1;
    if(x == rank) {
        return tree;
    }else if(x < rank){
        return OS_Select(tree->left, x);
    }else
    {
        return OS_Select(tree->right, x - rank);
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
int main() {
    //int arr[n];
    //FillRandomArray(arr, n, 1, 20, false, 0);
    //Branch *tree = createTree(n, arr, 0, n);

    /* ------------    TEST    ------------------------------*/
    int number = 9;
    int ex[20] = { 26, 17, 41, 14, 21, 30, 47, 10, 16, 19, 21, 28, 38, 7, 12, 14, 20, 35, 39, 3};
    Branch *testRoot = createTree(20, ex, 20);
    Branch * selected = OS_Select(testRoot, number);

    printTree(testRoot);
    printf("The %d'th smallest element is: %d\nWith Size: %d", number, selected->data, selected->size);
    //printTree(tree);
    return 0;
}