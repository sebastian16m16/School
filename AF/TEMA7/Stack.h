#include "Profiler.h"

typedef struct nod {
    int Key;
    struct nod* next;
} Stack;

void push(Stack** stack, int val) { //insert first in a linked list
    Stack* el = (Stack*)malloc(sizeof(Stack));
    el->Key = val;
    el->next = (*stack);
    *stack = el;
}

int pop(Stack** stack)
{
    int n = -1;
    if (*stack != nullptr) {
        Stack* firstElement = (*stack);
        *stack = (*stack)->next;
        n = firstElement->Key;
        free(firstElement);
    }
    return n;
}

int empty(Stack* stack)
{
    return stack == nullptr;
}

void initStack(Stack** stack) {
    *stack = nullptr;
}