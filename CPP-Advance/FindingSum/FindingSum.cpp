#include <iostream>
#include <vector>
#include <string>
#include <sstream>

using namespace std;

int b;

bool recursionFind(int position, vector<int> &v)
{
	if (position == v.size() - 1) {
		int sum = 0;
		for (int i = 0; i<v.size() - 1; i++) {
			sum += v[i];
		}

		if (sum == b)
			return true;
		else
			return false;
	}

	v[position] *= -1;
	if (recursionFind(position + 1, v) == true)
		return true;
	v[position] *= -1;

	if (recursionFind(position + 1, v))
		return true;

	return false;
}

int main()
{
	

	string line;
	while (getline(cin, line)) {
		if (line == "")
			break;

		stringstream ss(line);
		int current;
		vector<int> v;

		while (ss >> current) {
			v.push_back(current);
		}
		b = v[v.size() - 1];

		
		if (recursionFind(1, v)==false) {
			cout << endl;
		}
		else {
			cout << v[0];
			for (int i = 1; i<v.size() - 1; i++) {
				if (v[i]>0) {
					cout << "+";
				}
				cout << v[i];
			}
			cout << "=" << b;
			cout << endl;
		}
		
	}

	return 0;
}