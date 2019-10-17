#include <iostream>
#include <cstdio>
#include "Profiler.h"

const int n = 10000;
Profiler profiler("Ideal");


void bubbleSort(int* arr, int x) {

    int size = x;
    int aux;
    bool swaps = true;

    while (swaps) {
        swaps = false;
        for (int j = 0; j < size; j++) {
            for (int i = 0; i < size - 1; i++) {
                profiler.countOperation("BS_comp", x, 1);
                if (arr[i] > arr[i + 1]) {
                    aux = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = aux;
                    swaps = true;
                    profiler.countOperation("BS_assign", x, 3);
                }
            }
            --size;
        }
    }
}

void selectionSort(int* arr, int x) {
    int min_index;
    int aux;

    for (int i = 0; i < x; i++) {
        //profiler.countOperation("SS", x, 1);
        min_index = i;
        for (int j = i + 1; j < x; j++) {
            profiler.countOperation("SS_comp", x, 1);
            if (arr[j] < arr[min_index]) {
                min_index = j;
            }
        }
        if (i != min_index) {
            aux = arr[i];
            arr[i] = arr[min_index];
            arr[min_index] = aux;
            profiler.countOperation("SS_assign", x, 3);
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
    for (i = 1; i < x; i++)
    {
        profiler.countOperation("IS_assign", x, 1);
        key = arr[i];
        j = i - 1;


        while (j >= 0 && arr[j] > key)
        {
            profiler.countOperation("IS_comp", x, 1);
            profiler.countOperation("IS_assign", x, 1);
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        if (j >= 0)
            profiler.countOperation("IS_comp", x, 1);
        profiler.countOperation("IS_assign", x, 1);
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

    profiler.showReport();
    return 0;
}