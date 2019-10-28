/*
 * Heapsort is the ideal algorithm for sorting an array if you are to choose between quicksort and heapsort. It uses Heapify which has a time complexity of O(Logn)
 * and Build_max_heap which has a time complexity of O(n) resulting in an overall time complexity of O(nLogn)
 *
 * Quicksort being a divide and conquer algorithm it picks an element as pivot and partitions the given array around the picked pivot.
 * Depends on the case... it has different time complexities: Worst: O(n^2), Best: O(nLogn) and Average: O(nLogn)
 *
 * Both algorithms have For the average case O(nLogn), but considering the fact that in the worst case, the Quicksort algorithm is really slow, that gives a big
 * advantage to the Heapsort, making the Heapsort algorithm the best choice
 */



#include "Profiler.h"
const int n = 10000;

Profiler profiler("HeapSort_QuickSort");

//Heapsort
bool fare(int x){
    return x % 2 == 0;
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

//QuickSort
int partition(int *a, int first, int last, Operation comp, Operation assign){
    int pivot = a[last];
    assign.count(1);
    int i = (first-1);

    for(int j=first; j <= last-1; j++){
        comp.count(1);
        if(a[j] <= pivot){
            i++;
            swap(i, j, a);
            assign.count(3);
        }
    }
    swap(i+1, last, a);
    assign.count(3);
    return i+1;
}
void QuickSort(int *a, int first, int last, Operation comp, Operation assign){
    int pivot = 0;
    if(first < last){
        assign.count(1);
        pivot = partition(a, first, last, comp, assign);
        QuickSort(a, first, pivot - 1, comp, assign);
        QuickSort(a, pivot + 1, last, comp, assign);
    }
}

//QuickSelect
int QuickSelect(int *a, int left, int right, int key, Operation comp, Operation assign){

    if(left == right)
        return a[left];

    int pivot = partition(a, left, right, comp, assign);

    if(key == pivot)
        return a[key];
    if(key < pivot)
        right = pivot - 1;
    else
        left = pivot + 1;

    return QuickSelect(a, left, right, key, comp, assign);
}

int main() {
    int a[n];
    int b[n];

//    printArray(a, n);
//    QuickSort(a, 0, n);
//    printArray(a, n);
//
//    int key = 8;
//    int realKey = key -1;
//    printf("The %d'th smallest element is: %d\n", key, QuickSelect(a, 0, n, key));

    for(int i=0; i<5; i++){
        for(int j=10; j <= n; j+=10){
            Operation HeapSort_Comp = profiler.createOperation("HeapSort_Comp", j);
            Operation HeapSort_Assign = profiler.createOperation("HeapSort_Assign", j);

            Operation QuickSort_Comp = profiler.createOperation("QuickSort_Comp", j);
            Operation QuickSort_Assign = profiler.createOperation("QuickSort_Assign", j);

            FillRandomArray(a, j, 1, 20, false, 0);
            copyArray(a, b, j);

            HeapSort(a, j, HeapSort_Comp, HeapSort_Assign);
            QuickSort(b, 0, j, QuickSort_Comp, QuickSort_Assign);
        }
    }

    profiler.addSeries("HeapSort", "HeapSort_Comp", "HeapSort_Assign");
    profiler.addSeries("QuickSort", "QuickSort_Comp", "QuickSort_Assign");

    profiler.createGroup("General", "HeapSort","QuickSort");
    profiler.createGroup("Comparisons", "HeapSort_Comp","QuickSort_Comp");
    profiler.createGroup("Assignations", "HeapSort_Assign","QuickSort_Assign");


    //Caz favorabil

    profiler.reset("Favorabil");


    for(int j=10; j <= n; j+=10){
        Operation HeapSort_Comp = profiler.createOperation("HeapSort_Comp", j);
        Operation HeapSort_Assign = profiler.createOperation("HeapSort_Assign", j);

        Operation QuickSort_Comp = profiler.createOperation("QuickSort_Comp", j);
        Operation QuickSort_Assign = profiler.createOperation("QuickSort_Assign", j);

        FillRandomArray(a, j, 1, 20, false, 1);
        copyArray(a, b, j);

        HeapSort(a, j, HeapSort_Comp, HeapSort_Assign);
        QuickSort(b, 0, j, QuickSort_Comp, QuickSort_Assign);
    }


    profiler.addSeries("HeapSort", "HeapSort_Comp", "HeapSort_Assign");
    profiler.addSeries("QuickSort", "QuickSort_Comp", "QuickSort_Assign");

    profiler.createGroup("General_Ideal", "HeapSort","QuickSort");
    profiler.createGroup("Comparisons_Ideal", "HeapSort_Comp","QuickSort_Comp");
    profiler.createGroup("Assignations_Ideal", "HeapSort_Assign","QuickSort_Assign");

    //Caz defavorabil

    profiler.reset("Defavorabil");


    for(int j=10; j <= n; j+=10){
        Operation HeapSort_Comp = profiler.createOperation("HeapSort_Comp", j);
        Operation HeapSort_Assign = profiler.createOperation("HeapSort_Assign", j);

        Operation QuickSort_Comp = profiler.createOperation("QuickSort_Comp", j);
        Operation QuickSort_Assign = profiler.createOperation("QuickSort_Assign", j);

        FillRandomArray(a, j, 1, 20, false, 2);
        copyArray(a, b, j);

        HeapSort(a, j, HeapSort_Comp, HeapSort_Assign);
        QuickSort(b, 0, j, QuickSort_Comp, QuickSort_Assign);
    }


    profiler.addSeries("HeapSort", "HeapSort_Comp", "HeapSort_Assign");
    profiler.addSeries("QuickSort", "QuickSort_Comp", "QuickSort_Assign");

    profiler.createGroup("General_Worst", "HeapSort","QuickSort");
    profiler.createGroup("Comparisons_Worst", "HeapSort_Comp","QuickSort_Comp");
    profiler.createGroup("Assignations_Worst", "HeapSort_Assign","QuickSort_Assign");

    profiler.showReport();

    return 0;
}