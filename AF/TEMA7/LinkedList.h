#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <assert.h>


typedef struct LinkedList
{
    void *data;
    struct LinkedList * next;

    struct LinkedList *(*add)(struct LinkedList **,struct  LinkedList **, void*, size_t); //add node
    void(*removeNode)(struct LinkedList **,struct  LinkedList **,struct  LinkedList *); //remove node
    void(*displayList)(struct LinkedList *, void(*)(void*)); //display linked list
}LinkedList;

void removeNode(LinkedList ** Head, LinkedList ** Last, LinkedList *node){
    if(node != NULL){
        LinkedList * temp = (*Head);
        LinkedList * prev = NULL;

        assert(temp != NULL);

        while(temp != NULL){

            if(temp == node)
                break;

            prev = temp;
            temp = temp->next;
        }

        if(temp != NULL){
            if(temp != (*Head))
            {
                if(temp != (*Last))
                    prev->next = temp->next;
                else{
                    prev->next = NULL;
                    (*Last) = prev;
                }
            }
            else{
                (*Head) = temp->next;
            }
            printf("\nThe node with this data has been removed: \n");
            void(*display)(void *);
            free(temp);
            return;
        }
        printf("\nNo such node!\n");
    }
}

LinkedList * add(LinkedList ** Head, LinkedList ** Last, void * data, size_t data_size){
    LinkedList * node = (LinkedList *)malloc(sizeof(LinkedList));

    node->data = malloc(data_size);
    node->next = NULL;

    for(int i=0; i<data_size; i++)
        *(char *)(node->data + i) = *(char *)(data + i);

    if((*Head)==NULL){
        (*Head) = (*Last) = node;
    }
    else{
        (*Last)->next = node;
        (*Last) = node;
    }
    printf("Node added!!\n");
    return node;
}

void displayList(LinkedList * List, void(*func)(void*)){

    LinkedList * temp = List;
    int i=1;
    while(temp != NULL){
        printf("\nData %d: \n", i++);
        func(temp->data);
        temp = temp->next;
    }

}

LinkedList * LinkedListInit(void * data){
    LinkedList * List = (LinkedList*)malloc(sizeof(LinkedList));

    List->data = data;
    List->add = &add;
    List->removeNode = &removeNode;
    List->displayList = &displayList;
}
