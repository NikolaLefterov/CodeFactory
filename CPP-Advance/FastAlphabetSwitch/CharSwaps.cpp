#include <iostream>
#include <string>
#include<vector>
#include <sstream>
using namespace std;

int main()
{
	string txt;
	while (cin >> txt)
	{
		int cur;
		vector<int> Vec;
		while (cin >> cur) {

			Vec.push_back(cur);
			if (cin.get() == '\n') {
				break;
			}
		}
		for (size_t i = 0; i < Vec.size(); i++)
		{
			if (Vec[i] > txt.size())
			{
				for (size_t j = Vec[i]%txt.size(); j < txt.size(); j++)
				{
					cout << txt[j];
				}
				for (size_t k = 0; k < Vec[i] % txt.size(); k++)
				{
					cout << txt[k];
				}
				cout << endl;

			}
			else if (Vec[i] == 0)
			{
				for (size_t j = 0; j < txt.size(); j++)
				{
					cout << txt[j];
				}
				cout << endl;
			}
			else {
				for (size_t j = Vec[i]; j < txt.size(); j++)
				{
					cout << txt[j];
				}
				for (size_t k = 0; k < Vec[i]; k++)
				{
					cout << txt[k];
				}
				cout << endl;
			}
		}
	}
	//	cout << endl;
	return 0;
}
