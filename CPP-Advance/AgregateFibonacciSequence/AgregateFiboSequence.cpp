#include <iostream>
using namespace std;

int main()
{
	int a, b;
	int counter;
	while (cin >> a >> b >> counter)
	{

		long long unsigned *array1 = new long long unsigned[counter];
		for (size_t i = 0; i < counter; i++)
		{
			cin >> array1[i];
		}
		long long unsigned num1 = a;
		long long unsigned num2 = b;
		long long unsigned num_next = 1;
		const unsigned n = 10000;
		long long unsigned arrayFib[n];
		unsigned *array = new unsigned[counter];

		arrayFib[0] = 1; arrayFib[1] = 1;
		for (int i = 2; i<n; i++)
		{
			arrayFib[i] = (a*arrayFib[i - 1]) + (b * arrayFib[i - 2]);
		}
		for (size_t i = 0; i < counter; i++)
		{
			array[i] = 0;
			for (size_t j = 1; j < n; j++)
			{
				if (array1[i] == arrayFib[j])
				{
					array[i] = j+1;
				}
			}
		}
		for (size_t i = 0; i < counter; i++)
		{
			cout << array[i] << endl;
		}
	}
	return 0;
}
