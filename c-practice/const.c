#include <stdio.h>
#define add(x, y) x+y
#define pi 3.14159

int main () {

    const int a = 10; /*constant variable*/

    printf("Date: %s\n", __DATE__);/*predifined constants*/
    printf("Time: %s\n", __TIME__);
    printf("addition of two numbers is %d\n", add(4, 3));
    printf("result of expression a * b + c is %d\n", 5* add(4, 3));
     
    return 0;
}
