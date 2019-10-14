#include <iostream>
#include <cstdio>
#include "Profiler.h"

int n = 10;
Profiler profiler("SortProfiler");
//Operation bs1 = profiler.createOperation("BS-Moves", n);
//Operation ss1 = profiler.createOperation("SS-Moves", n);

void bubbleSort(int * arr, int x){

    int size = x;
    int aux;

    while(size != 0) {
        for (int j = 0; j < size; j++) {
            profiler.countOperation("BS", x, 1);
            for (int i = 0; i < size - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    aux = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = aux;
                    profiler.countOperation("BS", x, 3);
                }
            }
            --size;
        }
    }
}

void selectionSort(int * arr, int x){
    int min_index;
    int aux;

    for(int i=0; i<x; i++){
        profiler.countOperation("SS", x, 1);
        min_index = i;
        for(int j=i+1; j < x; j++){
            if(arr[j] < arr[min_index]){
                min_index = j;
            }
        }
        aux = arr[i];
        arr[i] = arr[min_index];
        arr[min_index] = aux;
        profiler.countOperation("SS", x, 3);
    }
}

void merge(int arr[], int l, int m, int r) {
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;

    /* create temp arrays */
    int L[n1], R[n2];

    /* Copy data to temp arrays L[] and R[] */
    for (i = 0; i < n1; i++){
        profiler.countOperation("MS", r, 1);
    L[i] = arr[l + i];
    }
    for (j = 0; j < n2; j++) {
        profiler.countOperation("MS", r, 1);
        R[j] = arr[m + 1+ j];
    }

    /* Merge the temp arrays back into arr[l..r]*/
    i = 0; // Initial index of first subarray
    j = 0; // Initial index of second subarray
    k = l; // Initial index of merged subarray
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            profiler.countOperation("MS", r, 1);
            i++;
        }
        else
        {
            arr[k] = R[j];
            profiler.countOperation("MS", r, 1);
            j++;
        }
        k++;
    }

    /* Copy the remaining elements of L[], if there
       are any */
    while (i < n1)
    {
        arr[k] = L[i];
        profiler.countOperation("MS", r, 1);
        i++;
        k++;
    }

    /* Copy the remaining elements of R[], if there
       are any */
    while (j < n2)
    {
        arr[k] = R[j];
        profiler.countOperation("MS", r, 1);
        j++;
        k++;
    }
}

void mergeSort(int arr[], int l, int r)
{
    if (l < r)
    {

        // Same as (l+r)/2, but avoids overflow for
        // large l and h
        int m = l+(r-l)/2;

        // Sort first and second halves
        mergeSort(arr, l, m);
        mergeSort(arr, m+1, r);

        merge(arr, l, m, r);
    }
}

void printArray(int * arr, int x){
    for(int i=0; i<x; i++){
        printf("%d ", arr[i]);
    }
    printf("\n");
}

void copyArrayAtoB(int *a, int *b, int x){
    for(int i=0; i < x; i++){
        b[i] = a[i];
    }
}

int main() {

    int a[1000];
    int b[1000];
    int c[1000];
    FillRandomArray(a, 1000, 1, 60, false, 0);
    copyArrayAtoB(a, b, 1000);
    copyArrayAtoB(a, c, 1000);

        printf("THE ARRAY: \n");
        printArray(a, n);
        printf("\n");
        printf("\n");

    for(int j=0; j <= 1000; j++) {
        for (int i = 10; i < 1000; i += 10) {
            bubbleSort(a, i);
            selectionSort(b, i);
            mergeSort(c, 0, i);
        }
    }
    printArray(a, 1000);
    printf("\n");
    printf("\n");
    printArray(b, 1000);
    printf("\n");
    printf("\n");
    printArray(c, 1000);
    printf("\n");
    printf("\n");

    profiler.createGroup("BSearch", "BS", "SS", "MS");
    profiler.showReport();

    return 0;
}