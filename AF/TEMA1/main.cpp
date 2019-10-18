/*
 * Ideal:
 *In the ideal case the only one who makes assignations is the Insertion sort algorithm and when it comes to comparing, Insertion sort does the least comparing operations. In general, if we take an overall comparison Selection Sort does the most operations,
 *Bubble Sort comes right after and the Insertion Sort does the least operations. In ideal case - the right choice is the Insertion sort.
 *
 * Worst:
 * In the worst case the the one who makes the least assignations is the Selection sort, after that it comes the Insertion Sort and then the Bubble sort. When it comes to comparisons they are all around the same area, only the Insertion Sort has less
 * comparisons, but just with a few.. nevertheless that make the Insertion sort be the favorite in this area. The average of the algorithms in this case scenario shows that the Selection Sort has the least operations, followed by the Insertion Sort and
 * then the Bubble sort. So in the case "worst" the one to choose is the Selection Sort
 *
 * Statistic:
 * In the statistic case Selection Sort has the least assignations but the most comparisons, the Bubble Sort has the most assignations and the second number of comparisons. The Insertion sort is second in assignations and first
 * (when it comes to the least number of comparisons).  In the general scope, we get an average of the operations and the algorithm to choose is Insertion Sort
 *
 * Conclusion:
 * After evaluating every case scenario, the best algorithm with the least operations (in average) is the Insertion Sort.
 * The second best is Selection Sort and the third is the Bubble sort.
*/





#include <iostream>
#include <cstdio>
#include "Profiler.h"

const int n = 10000;
Profiler profiler("Statistic");

void bubbleSort(int* arr, int x) {

    int size = x;
    int aux;
    bool swaps = true;

    while (swaps) {
        swaps = false;
        Operation BS_comp = profiler.createOperation("BS_comp", x);
        Operation BS_assign = profiler.createOperation("BS_assign", x);
        for (int j = 0; j < size; j++) {
            for (int i = 0; i < size - 1; i++) {
                //profiler.countOperation("BS_comp", x, 1);
                BS_comp.count(1);
                if (arr[i] > arr[i + 1]) {
                    aux = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = aux;
                    swaps = true;
                    BS_assign.count(3);
                    //profiler.countOperation("BS_assign", x, 3);
                }
            }
            --size;
        }
    }
}

void selectionSort(int* arr, int x) {
    int min_index;
    int aux;

    Operation SS_comp = profiler.createOperation("SS_comp", x);
    Operation SS_assign = profiler.createOperation("SS_assign", x);
    for (int i = 0; i < x; i++) {
        //profiler.countOperation("SS", x, 1);
        min_index = i;
        for (int j = i + 1; j < x; j++) {
            //profiler.countOperation("SS_comp", x, 1);
            SS_comp.count(1);
            if (arr[j] < arr[min_index]) {
                min_index = j;
            }
        }
        if (i != min_index) {
            aux = arr[i];
            arr[i] = arr[min_index];
            arr[min_index] = aux;
            SS_assign.count(3);
            //profiler.countOperation("SS_assign", x, 3);
        }
    }
}

/* for i = 2 to n
 * aux = A[i]
 * j=i=1;
 * while j>= 1 & aux < A[j]
 *      A[j+1] = A[j]
 *      j= j -1
 * A[j+1] = aux
 *
 * */

void insertionSort(int arr[], int x)
{
    int i, key, j;

    Operation IS_comp = profiler.createOperation("IS_comp", x);
    Operation IS_assign = profiler.createOperation("IS_assign", x);
    for (i = 1; i < x; i++)
    {
        //profiler.countOperation("IS_assign", x, 1);
        IS_assign.count(1);
        key = arr[i];
        j = i - 1;


        while (j >= 0 && arr[j] > key)
        {
            //profiler.countOperation("IS_comp", x, 1);
            //profiler.countOperation("IS_assign", x, 1);
            IS_comp.count(1);
            IS_assign.count(1);
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        if (j >= 0) {
            //profiler.countOperation("IS_comp", x, 1);
            IS_comp.count(1);
        }
        //profiler.countOperation("IS_assign", x, 1);
        IS_assign.count(1);
        arr[j + 1] = key;
    }
}

void printArray(int* arr, int x) {
    for (int i = 0; i < x; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}

void copyArrayAtoB(int* a, int* b, int x) {
    for (int i = 0; i < x; i++) {
        b[i] = a[i];
    }
}

int main(){

    int a[n];
    int b[n];
    int c[n];


    /*printf("THE ARRAY: \n");
    printArray(a, n);
    printf("\n");
    printf("\n");*/

    for (int j = 0; j <= 5; j++) {
        for (int i = 100; i < n; i += 300) {
            FillRandomArray(a, i, 1, 60000, false, 0);
            copyArrayAtoB(a, b, i);
            copyArrayAtoB(a, c, i);

            //statistic
            bubbleSort(a, i);
            selectionSort(b, i);
            insertionSort(c, i);
        }
    }
    /*printArray(a, n);
    printf("\n");
    printf("\n");
    printArray(b, n);
    printf("\n");
    printf("\n");
    printArray(c, n);
    printf("\n");
    printf("\n");*/

    profiler.addSeries("BS", "BS_comp", "BS_assign");
    profiler.addSeries("SS", "SS_comp", "SS_assign");
    profiler.addSeries("IS", "IS_comp", "IS_assign");

    profiler.createGroup("Comp_STATISTIC", "BS_comp", "SS_comp", "IS_comp");
    profiler.createGroup("Assign_STATISTIC", "BS_assign", "SS_assign", "IS_assign");
    profiler.createGroup("Operations_STATISTIC", "BS", "SS", "IS");


    //ideal

    profiler.reset("Ideal");


    for (int i = 100; i < n; i += 300) {
        FillRandomArray(a, i, 1, 60000, false, 1);
        copyArrayAtoB(a, b, i);
        copyArrayAtoB(a, c, i);

        //Ideal
        bubbleSort(a, i);
        selectionSort(b, i);
        insertionSort(c, i);
    }

    profiler.addSeries("BS", "BS_comp", "BS_assign");
    profiler.addSeries("SS", "SS_comp", "SS_assign");
    profiler.addSeries("IS", "IS_comp", "IS_assign");

    profiler.createGroup("Comp_IDEAL", "BS_comp", "SS_comp", "IS_comp");
    profiler.createGroup("Assign_IDEAL", "BS_assign", "SS_assign", "IS_assign");
    profiler.createGroup("Operations_IDEAL", "BS", "SS", "IS");

    //worst

    profiler.reset("Worst");

    for (int i = 100; i < n; i += 300) {
        FillRandomArray(a, i, 1, 60000, false, 2);
        copyArrayAtoB(a, b, i);
        copyArrayAtoB(a, c, i);

        //Ideal
        bubbleSort(a, i);
        selectionSort(b, i);
        insertionSort(c, i);
    }


    profiler.addSeries("BS", "BS_comp", "BS_assign");
    profiler.addSeries("SS", "SS_comp", "SS_assign");
    profiler.addSeries("IS", "IS_comp", "IS_assign");

    profiler.createGroup("Comp_WORST", "BS_comp", "SS_comp", "IS_comp");
    profiler.createGroup("Assign_WORST", "BS_assign", "SS_assign", "IS_assign");
    profiler.createGroup("Operations_WORST", "BS", "SS", "IS");


    profiler.showReport();

    return 0;
}