#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include "Profiler.h"

int n = 10;
Profiler profiler("SortProfiler");


void bubbleSort(int * arr, int n){
    int size = n;
    int aux;

    while(size != 0) {
        profiler.countOperation("Moves", n, 1);
        for (int j = 0; j < size; j++) {
            for (int i = 0; i < size - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    aux = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = aux;
                    profiler.countOperation("Assignations", n, 3);

                }
            }
            --size;
        }
    }
}

void selectionSort(int * arr, int n){
    int min_index;
    int aux;

    for(int i=0; i<n; i++){
        min_index = i;
        for(int j=i+1; j < n; j++){
            if(arr[j] < arr[min_index]){
                min_index = j;
            }
        }
        aux = arr[i];
        arr[i] = arr[min_index];
        arr[min_index] = aux;

    }
}

void printArray(int * arr, int n){
    for(int i=0; i<n; i++){
        printf("%d ", arr[i]);
    }
    printf("\n");
}

int main() {

    int a[n];
    int b[n];
    FillRandomArray(b, n, 0, 60, false, 0);

    printf("Bubble\n");

    for(int i = 0; i < 10000; i++){
        FillRandomArray(a, n, 0, 60, false, 0);
        bubbleSort(a, n);

    }
    printArray(a, n);

    printf("SelectionSort\n");
    printArray(b, n);
    selectionSort(b, n);
    printArray(b, n);

    profiler.createGroup("BSearch", "Moves", "Assignations");
    profiler.showReport();

    return 0;
}