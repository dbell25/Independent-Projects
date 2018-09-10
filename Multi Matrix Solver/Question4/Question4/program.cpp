#include <stdlib.h>
#include <stdio.h>

int main() {
	int x;
	int i;
	int j;
	while (1) {
		printf("Enter a number: ");
		scanf("%d", &x);
		i = (int)(float)x;
		j = (int)(double)x;
		printf("x = %d\ni = %d\nj = %d\n\n", x, i, j);
		printf("a.) is %s\nb.) is %s\n\n", (x == i) ? "true" : "false", (x == j) ? "true" : "false");
	}
	return 0;
}
