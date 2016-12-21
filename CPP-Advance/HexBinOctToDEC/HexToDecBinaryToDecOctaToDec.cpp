#include <iostream>
#include <string>
#include <iomanip>
#include <sstream>
#include <math.h>
using namespace std;


int main() {
	//HEX to DEC 
	int input;
	cin >> input;
	if (input == 16) {
		string hexNumber;
		cin >> hexNumber;
		int decNumber;

		std::stringstream ss1;
		ss1 << hexNumber;
		ss1 >> std::hex >> decNumber;

		cout << decNumber << endl;
	}
	//Binary to DEC
	else if (input == 2) {
		long bin, dec = 0, rem, num, base = 1;

		cin >> num;
		bin = num;
		while (num > 0)
		{
			rem = num % 10;
			dec = dec + rem * base;
			base = base * 2;
			num = num / 10;
		}
		cout << dec << endl;
	}
	else if (input == 8) {
		long int octNumber, decnum = 0;
		int i = 0;

		cin >> octNumber;
		while (octNumber != 0)
		{
			decnum = decnum + (octNumber % 10) * pow(8, i);
			i++;
			octNumber = octNumber / 10;
		}
		cout << decnum;

	}




	return 0;
}