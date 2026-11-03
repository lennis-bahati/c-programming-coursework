//Refresh

#include <stdio.h>
#include <string.h>

int main(){
	
	char name[50];
	float a, b;
	
	printf("Enter your name:\n\n");
	fgets(name, sizeof(name), stdin);
	printf("\n");
	
	name[strcspn(name, "\n")]='\0';
	
	printf("Enter two numbers seperated by space:\n\n");
	scanf("%f %f", &a, &b );
	
	//Various arithmetic applications of a and b 
	float sum=a+b;
	float difference=a-b;
	float product=a*b;
	
	printf("\nHello, %s! , Here are your results\n",name);
	printf("\nSum:%.2f+%.2f=%.2f\n",a,b,sum);
	printf("\nDifference:%.2f-%.2f=%.2f\n",a,b,difference);
	printf("\nProduct:%.2f*%.2f=%.2f\n",a,b,product);
  	
	 return 0;
}