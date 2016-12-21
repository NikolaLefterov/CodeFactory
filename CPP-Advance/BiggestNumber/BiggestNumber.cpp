#include <iostream>
#include <algorithm>
#include <string>

using namespace std;


int main() {
	string input;
	int array[10];
	while (cin >> input) {
		for (size_t i = 0; i < 10; i++)
		{
			array[i] = 0;
		}
		for (size_t i = 0; i <input.length(); i++)
		{
			if (input[i] == '0')
				array[0]++;
			else if (input[i] == '1')
				array[1]++;
			else if (input[i] == '2')
				array[2]++;
			else if (input[i] == '3')
				array[3]++;
			else if (input[i] == '4')
				array[4]++;
			else if (input[i] == '5')
				array[5]++;
			else if (input[i] == '6')
				array[6]++;
			else if (input[i] == '7')
				array[7]++;
			else if (input[i] == '8')
				array[8]++;
			else if (input[i] == '9')
				array[9]++;
		}
		for (int i = 9; i >= 0; i--)
		{
			
			for (int j = 0; j <array[i]; j++)
			{
				cout << i;
			}
		}

		cout << endl;


	}
	
	
	
	
	return 0;
}