#include<iostream>
#include <fstream>
using namespace std;
int br = 0;
ofstream txt("example.txt");
void Hanoj(int n, char a, char b, char c)
{
	
	if (n>0)
	{
		
		Hanoj(n - 1, a, c, b);
		br++;
		cout << a << "--->" << c << endl;
		txt << br << " ) " << a << "-->" << c << endl;
		Hanoj(n - 1, b, a, c);
	}
}
int main()
{

	int n;
	cout << "Number of disks: "; 
	cin >> n;
		txt << "Number of disks: " << n << endl;
		char a = 'A';
		char b = 'B';
		char c = 'C';
		Hanoj(n, a, c, b);
		cout << "Number of moves: " << br << endl;
		txt << "Number of moves: " << br << endl;
		txt.close();
	
	return 0;
}
