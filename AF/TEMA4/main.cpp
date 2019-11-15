#include "Profiler.h"


const int n = 9973;
const int m = 3000;
const int min = 1;
const int max = 50000;


Profiler profiler("Statistic");

typedef enum{FREE} state;
int h_prime(int k){
    return k % n;
}
int h(int key, int i){
    int c1 =1, c2 =1;
    return (h_prime(key) + c1*i + c2 * i*i);
}

int hash_search(const int * arr,const int key, int &found, Operation cellsAccessed){
    int i = 0;

    do{
        int j = h(key, i);
        while(j > n-1)
        {
            j = j - n;
        }

        cellsAccessed.count(1);
        if(arr[j] == key){
            //printf("Key -> %d was found in slot %d!\n", key, j);
            found++;
            return j;
        } else
            i++;
    }while(i != n);
    //printf("Key -> %d was not found!!\n", key);
    return 0;
}

void hash_insert(int * arr, int key, int &numberOfElements){
    int i = 0;

    do{
        int j = h(key, i);
        while(j > n-1)
        {
            j = j - n;
        }
        if(arr[j] == FREE){
            arr[j] = key;
            numberOfElements++;
           // printf("Key -> %d was inserted in slot %d!\n", key, j);
            return;
        } else
            i++;
    }while(i != n);


}

float loadFactor(int numberOfElements){
    return (float)numberOfElements/n;
}

void printArray(int *arr, int length){
    for(int i = 0; i < length; i++){
        printf("%d ", arr[i]);
    }
    printf("\n");
}

int getRandom(int minRange, int maxRange){
    return (rand() % (maxRange - minRange + 1)) + minRange;
}

void initTable(int * table, int length){
    for(int i=0; i<length; i++){
        table[i] = FREE;
    }
}

bool inTable(const int *table, int length, int key){
    for(int i=0; i<length; i++){
        if(key == table[i]) return true;
    }
    return false;
}

void generateRandomHalf(int * table, int * arr){
    int number=0, i = 0;
    int present = 0, notThere = 0;
//    while(present < m/2 && notThere < m/2){
//        number = getRandom(1, 50);
//        if(inTable(table, length, number)){
//            if(present < m/2) {
//                arr[i++] = number;
//                present++;
//            }
//        }else if(notThere < m/2){
//            arr[i++] = number;
//            notThere++;
//        }
//    }

    while(present < m / 2 && notThere < m / 2){
        number = getRandom(min, max);
        if(inTable(table, n, number)){
            arr[i++] = number;
            present++;
        } else {
            arr[i++] = number;
            notThere++;
        }
    }
    while(present < m / 2){
        number = table[getRandom(1, n)];
        if(number != FREE) {
            arr[i++] = number;
            present++;
        }
    }
    while(notThere < (m/2 + m%2)){
        number = getRandom(min, max);
        if(!inTable(table, n, number)) {
            arr[i++] = number;
            notThere++;
        }
    }


}

bool test(const int * a1,const int * a2, int length){
    for(int i=0; i<length; i++){
        if(a1[i] != a2[i]) return false;
    }
    return true;
}

int main() {
    srand(time(NULL));
    //TEST

//int theRightResult[n] = {5, 36, 21, 26, 4, 19, 14};
//int toTest[n] = {19, 36, 5, 21, 4, 26, 14};
//
//int result[n];
//initTable(result, n);
//int numberOfElements = 0;
//
//printArray(theRightResult, n);
//printArray(toTest, n);
//
//
//for(int i=0; i<n; i++){
//    printArray(result, n);
//    hash_insert(result, toTest[i], numberOfElements);
//}
//
//printArray(result, n);
//printArray(theRightResult, n);
//if(test(result, theRightResult, n)){
//    printf("This is right!");
//}else{
//    printf("This is WRONG!");
//
//}

// Implementing




    int numberOfElements = 0, found = 0;
    int table[n], randArray[m];
    float loads[5] = {0.8, 0.85, 0.9, 0.95, 0.99};
    int nElements[25];
    int nFound[25];
    initTable(nElements, 5);
    initTable(nFound, 5);
    int next = 0;

    for(int i=0; i<5; i++) {
        for (float load : loads) {


            initTable(table,n);
            numberOfElements = found = 0;
            while (loadFactor(numberOfElements) < load) {
                hash_insert(table, getRandom(min, max), numberOfElements);
               // printf("Load Factor = %2f\n", loadFactor(numberOfElements));
            }
            generateRandomHalf(table, randArray);

            Operation cellsAccessed1 = profiler.createOperation("Effort_Mediu_Gasite", load);
//            Operation cellsAccessed2 = profiler.createOperation("Effort_Maxim_Gasite", load);
//            Operation cellsAccessed3 = profiler.createOperation("Effort_Mediu_NeGasite", load);
//            Operation cellsAccessed4 = profiler.createOperation("Effort_Maxim_NeGasite", load);
            //printArray(table, n);
            //printArray(randArray, m);
            for(int elem : randArray){
                hash_search(table, elem, found, cellsAccessed1);
            }
            printf("I am here #%d (25)\n", next+1);
            nElements[next] = numberOfElements;
            nFound[next] = found;
            next++;
        }
    }

    for(int j=0; j<5; j++){
        for(int i=0; i<5; i++){
            printf("\n(Load Factor = %2f):\nCASE #%d \n", loads[j],i+1);
            printf("Inserted %d elements out of %d\n", nElements[i+j], n);
            printf("Found %d elements out of %d\n\n", nFound[i+j], m);
        }
    }

    profiler.showReport();

    return 0;
}