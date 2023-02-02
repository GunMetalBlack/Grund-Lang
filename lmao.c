// This is an example of how, despite all flaws, Grund is still superior to C. We live in a society.

#include <stdio.h>

#define FALSE 0
#define TRUE 1
#define BOOL int

void print_boolean(BOOL x) {
    printf("%s\n", x ? "true" : "false");
}

struct student {
    const char* name;
    BOOL absent;
    unsigned int period;
};

void student_show_up_to_class(struct student* x) {
    x->absent = FALSE;
}

int main() {
    struct student a;
    a.name = "Jeff";
    a.absent = TRUE;
    a.period = 6;
    print_boolean(a.absent);
    student_show_up_to_class(&a);
    print_boolean(a.absent);
    return 0;
}