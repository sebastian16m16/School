/*
 * The most favorable approach to Heap Construction is the Bottom_Up approach because it starts the Max_Heapify operation from the middle of the array and so it does the heapify length/2 times.
 * The top down approach needs to do the heapify every time the heap has a new element inserted, for the whole "new" heap, so the top down calls the heapify minimum LengthOfArray times.
 *
 * To understand better the complexity:
 * For Bottom_Up: n + nlogn = nlogn
 * For TopDown: nlogn + nlogn = nlogn
 */



#include "Profiler.h"
const int n = 10000;

Profiler profiler("Heap_UP");

bool fare(int n){
    return n % 2 == 0;
}

int left(int i){
    return (i * 2) + 1;
}

int right(int i){
    return (i*2) + 2;
}

int head(int i){
    if(i == 0) return 0;
    if(!fare(i)){
        return (i-1)/2;
    }else
        return (i-2)/2;
}

void swap(int xPos, int yPos, int * a){
    int aux = a[xPos];
    a[xPos] = a[yPos];
    a[yPos] = aux;
}

bool isLeaf(int i, int length){
    return i > (length / 2) && i <= length;
}

void max_heapify(int * a, int length, int i, Operation comp, Operation assign){
    if(isLeaf(i, length))
        return;

    int max = 0;
    comp.count(1);
    if(left(i) < length && a[left(i)] > a[i]){
        max = left(i);
    }else
    {
        max = i;
    }

    comp.count(1);
    if(right(i) < length && a[right(i)] > a[max]){
        max = right(i);
    }

    if(max != i){
        swap(i, max, a);
        assign.count(3);

    }else if(max == i)
        return;

    max_heapify(a, length, max, comp, assign);
}

void Build_Max_Heap(int * a, int length, Operation comp, Operation assign){

    for(int i=((length-1)/2); i >= 0; i--){
        max_heapify(a, length, i, comp, assign);
    }
}
void printArray(int *a, int length){
    for(int i=0; i < length; i++){
        printf("%d ", a[i]);
    }
    printf("\n");
}

void copyArray(const int * source, int * target, int length){
    for(int i = 0; i < length; i++){
        target[i] = source[i];
    }
}

void HeapSort(int *a, int length, Operation comp, Operation assign){
    Build_Max_Heap(a, length, comp, assign);
    for(int i=length-1; i > 0; i--){
        swap(0, i, a);
        assign.count(3);
        length--;
        max_heapify(a, length, 0, comp, assign);
    }
}

void top_down_constr(int * a, int length, Operation comp, Operation assign){
    for(int i=0; i<(length); i++){
        for(int j=((i)/2); j >= 0; j--)
            max_heapify(a, i, j, comp, assign);
    }
}

bool checkAlgorithmsOutput(int *a, int *b, int length){
    for(int i=0; i<length; i++){
        if(a[i] != b[i])
            return false;
    }
    return true;
}

void Heap_Increase_Key(int *a, int i, Operation comp, Operation assign){
    comp.count(1);
    while(i > 0 && a[head(i)] < a[i]){
        swap(i, head(i), a);
        assign.count(3);
        i = head(i);
    }
}

void Build_Heap_Top_Down(int * a, int length, Operation comp, Operation assign){
    for(int i=1; i < length; i++){
        Heap_Increase_Key(a, i, comp, assign);
    }
}

int main() {

    int a[n];
    int b[n];
    int c[n];
    //int b[n] = { 5, 8, 13, 2, 11, 1, 2, 6, 9, 0};
//
//            FillRandomArray(a, n, 1, 50, false, 0);
//            copyArray(a, b, n);
//            copyArray(a, c, n);
//            Operation BottomUp_Comp = profiler.createOperation("BottomUp_Comp",n);
//            Operation BottomUp_Assign = profiler.createOperation("BottomUp_Assign",n);
//            Operation TopDown_Comp = profiler.createOperation("TopDown_Comp",n);
//            Operation TopDown_Assign = profiler.createOperation("TopDown_Assign",n);
//            Operation HeapSortO_Comp = profiler.createOperation("HeapSort_Comp",n);
//            Operation HeapSortO_Assign = profiler.createOperation("HeapSort_Assign",n);
//
//    printf("Bottom_UP: ");
//    printArray(a, n);
//    Build_Max_Heap(a, n, BottomUp_Comp, BottomUp_Assign);
//    printf("Max_Heap_BottomUp: ");
//    printArray(a, n);
//    printf("\n");
//
//    printf("Heap_Sort: ");
//    printArray(c, n);
//    HeapSort(c, n, HeapSortO_Comp, HeapSortO_Assign);
//    printf("Heap_Sorted: ");
//    printArray(c, n);
//    printf("\n");
//
//    printf("Top_DOWN: ");
//    printArray(b, n);
//    Build_Heap_Top_Down(b, n);
//    printf("Max_Heap_TopDown: ");
//    printArray(b, n);
//    printf("\n");

    for(int i=0; i<5; i++){
        for(int j=100; j< n; j+=100){
            FillRandomArray(a, j, 1, 50000, false, 0);
            copyArray(a, b, n);
            Operation BottomUp_Comp = profiler.createOperation("BottomUp_Comp",j);
            Operation BottomUp_Assign = profiler.createOperation("BottomUp_Assign",j);
            Operation TopDown_Comp = profiler.createOperation("TopDown_Comp",j);
            Operation TopDown_Assign = profiler.createOperation("TopDown_Assign",j);
//            Operation HeapSortO_Comp = profiler.createOperation("HeapSort_Comp",j);
//            Operation HeapSortO_Assign = profiler.createOperation("HeapSort_Assign",j);
            Build_Max_Heap(a, j, BottomUp_Comp, BottomUp_Assign);
            Build_Heap_Top_Down(b, j, TopDown_Comp, TopDown_Assign);
        }
    }

    profiler.addSeries("BottomUp", "BottomUp_Comp", "BottomUp_Assign");
    profiler.addSeries("TopDown", "TopDown_Comp", "TopDown_Assign");

    profiler.createGroup("General", "BottomUp", "TopDown");
    profiler.createGroup("Comparisons", "BottomUp_Comp", "TopDown_Comp");
    profiler.createGroup("Assignations", "BottomUp_Assign", "TopDown_Assign");



    profiler.reset("Defavorabil");



    for(int j=100; j< n; j+=100){
        FillRandomArray(a, j, 1, 50000, false, 1);
        copyArray(a, b, n);
        Operation BottomUp_Comp = profiler.createOperation("BottomUp_Comp",j);
        Operation BottomUp_Assign = profiler.createOperation("BottomUp_Assign",j);
        Operation TopDown_Comp = profiler.createOperation("TopDown_Comp",j);
        Operation TopDown_Assign = profiler.createOperation("TopDown_Assign",j);
//            Operation HeapSortO_Comp = profiler.createOperation("HeapSort_Comp",j);
//            Operation HeapSortO_Assign = profiler.createOperation("HeapSort_Assign",j);
        Build_Max_Heap(a, j, BottomUp_Comp, BottomUp_Assign);
        Build_Heap_Top_Down(b, j, TopDown_Comp, TopDown_Assign);
    }

    profiler.addSeries("BottomUp", "BottomUp_Comp", "BottomUp_Assign");
    profiler.addSeries("TopDown", "TopDown_Comp", "TopDown_Assign");

    profiler.createGroup("General_Defavorabil", "BottomUp", "TopDown");
    profiler.createGroup("Comparisons_Defavorabil", "BottomUp_Comp", "TopDown_Comp");
    profiler.createGroup("Assignations_Defavorabil", "BottomUp_Assign", "TopDown_Assign");



    profiler.reset("Favorabil");

    for(int j=100; j< n; j+=100){
        FillRandomArray(a, j, 1, 50000, false, 2);
        copyArray(a, b, n);
        Operation BottomUp_Comp = profiler.createOperation("BottomUp_Comp",j);
        Operation BottomUp_Assign = profiler.createOperation("BottomUp_Assign",j);
        Operation TopDown_Comp = profiler.createOperation("TopDown_Comp",j);
        Operation TopDown_Assign = profiler.createOperation("TopDown_Assign",j);
//            Operation HeapSortO_Comp = profiler.createOperation("HeapSort_Comp",j);
//            Operation HeapSortO_Assign = profiler.createOperation("HeapSort_Assign",j);
        Build_Max_Heap(a, j, BottomUp_Comp, BottomUp_Assign);
        Build_Heap_Top_Down(b, j, TopDown_Comp, TopDown_Assign);
    }

    profiler.addSeries("BottomUp", "BottomUp_Comp", "BottomUp_Assign");
    profiler.addSeries("TopDown", "TopDown_Comp", "TopDown_Assign");

    profiler.createGroup("General_Favorabil", "BottomUp", "TopDown");
    profiler.createGroup("Comparisons_Favorabil", "BottomUp_Comp", "TopDown_Comp");
    profiler.createGroup("Assignations_Favorabil", "BottomUp_Assign", "TopDown_Assign");

    profiler.showReport();

    return 0;
}