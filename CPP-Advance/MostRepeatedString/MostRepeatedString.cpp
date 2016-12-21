#include <iostream>
#include <string>
#include <vector>

using namespace std;


int main() {
	int n = 0;
	
	while (cin >> n) {
		int half = n / 2;
		int counter = 0;
		int position = 0;
		vector<string> text(n);
		for (size_t i = 0; i < n; i++)
			cin >> text[i];
		for (size_t i = 0; i < n-1; i++)
		{
			if (counter > half) {
				cout << text[position]<< endl;
				break;
			}
			counter = 0;
			for (size_t j = 0; j < n; j++)
			{
				if (text[i] == text[j]) {
					counter++;
					position = i;
				}
			}
		}
	}
	

	
	return 0;
}
