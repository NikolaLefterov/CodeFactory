#include <iostream>
#include <algorithm>
#include <string>

using namespace std;




int main() {
	int examples;
	cin >> examples;
	for (size_t i = 0; i < examples; i++)
	{
		long long unsigned int  n;
		cin >> n;
		 long long unsigned int  * arr = new  long long unsigned int [n];
		for (size_t i = 0; i < n; i++)
		{
			cin >> arr[i];
		}
		sort(arr, arr + n);

		if (n % 2 == 0) {
			cout << arr[(n / 2) - 1] << endl;
		}
		else
			cout << arr[n / 2] << endl;
	}

	
	return 0;
}