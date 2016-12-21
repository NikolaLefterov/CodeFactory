#include <iostream>
using namespace std;

int GCD(int a, int b)
{
	int r;
	while (b != 0)
	{
		r = a%b;
		a = b;
		b = r;
	}
	return a;
}

int LCM(int a, int b)
{
	int LCM = (a*b) / GCD(a, b);
	return LCM;
}
int i = 1;
void dell(int a, int b) {
	int GCDab = GCD(a, b);
	a = a / GCDab;
	b = b / GCDab;
	if (b == 1)
	{
		cout << a << endl;
	}
	else if (b == 0)
	{
		cout << "0" << endl;
	}
	else {
		cout << a << "/" << b << endl;
	}
}

int main() {
	int m, n, p, q;
	char sign, sign1, sign2;
	int sum;
	int del;
	while (cin >> m >> sign1 >> n >> sign2 >> p >> sign >> q)
	{

		if (n == q)
		{
			sum = m + p;
			dell(sum, n);
		}
		else	if (n != q)
		{
			int x, x1;
			del = LCM(q, n);
			x = del / n;
			x1 = del / q;
			sum = (m*x) + (p*x1);
			dell(sum, del);
		}
	}
	return 0;
}
