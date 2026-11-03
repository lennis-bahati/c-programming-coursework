//Refresh


#include<stdio.h> 
int main(){
	printf("Hello,World!\n");
	printf("Here is my math problems solved\n");
	printf("\n____________________\n\n");
 
    //Simple Arithmetic
    printf("Question 1.\n\n");
    int a=1;
    int b=1;
    int sum=a+b;
    printf("1+1=%d\n",sum);
    printf("\n________________________________________\n\n");
    
    //Area of a Rectangle
    printf("Question 2.\n\n");
    printf("Area of a Rectangle is L*W.");
    printf("Below is an example:\n\n");
    
    float L=45.6f;
    float W=12.3f;
    float A=L*W;
    printf("The Area of the rectangle is %.2fcm squared\n",A);
    printf("\n_______________________________________\n\n");
    
    //Area of a Circle
    printf("Question 3.\n\n");
    printf("Area of a circle is pi*(radius*radius).");
    printf("Below is an example\n\n");
    
    float r=7.0f;
    float pi=3.1415f;
    float C=pi*(r*r);//Used c to indicate area as i have already used A
    printf("The Area of this Circle is %.2fcm squared\n",C);
    printf("\n_______________________________________\n\n");
    
    //Cylinder volume
    printf("Question 4.\n\n");
    printf("Volume of a cylinder is pi*(radius*radius)*h");
    printf("Below is an example \n\n");
    
    float rr=24.4f;
    float h=23.6f;
    float v=pi*(rr*rr)*h;
    printf("The volume is %.3fcm cubed\n",v);
    printf("\n_________________________________________\n\n");
    
    
    
	return 0;
}