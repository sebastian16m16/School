#include "Profiler.h"
int n = 0;

Profiler profiler = new Profiler("Heap-UP");

bool fare(int n){
    if(n % 2 == 0)
        return true;
    else
        return false;
}

int left(int i){
    return i * 2;
}

int right(int i){
    return i*2 + 1;
}

int head(int i){
    if(fare(i)){
        return i /2;
    }else
        return (i-1)/2;
}

void swap(int x, int y){
    int aux = x;
    x = y;
    y = aux;
}

void max_heapify(int * a, int length, int i){
    int max = 0;
    if(left(i) < length && a[left(i) > a[i]]){
        max = left(i);
    }else
    {
        max = i;
    }

    if(right(i) < length && a[right(i)] > a[max]){
        max = right(i);
    }

    if(max != i){
        swap(a[i], a[max]);
    }
    max_heapify(a, length, max);
}

void Build_Max_Heap(int * a, int length){

    for(int i=length-1/2; i >= 0; i--){
        max_heapify(a, length, i);
    }
}

void HeapSort(int *a, int length){
    Build_Max_Heap(a, length);

    for(int i=length; i > 1; i--){
        swap(a[left(i)], a[i]);
        length--;
        max_heapify(a, length, i);
    }
}


int main() {
    int a[n];
    FillRandomArray(a, n, 1, 50000, false, 0);


    return 0;
}