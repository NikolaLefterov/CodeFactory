#include <iostream>
#include <string>
#include <iomanip>
#include <sstream>
#include <cmath>
#include <time.h>
using namespace std;


int main() {


	int randNum;
	
	int counterPrime = 0;
	bool flag = false;
	srand(79561 % 100);
	for (int i = 1; i < 10000; i++) {

		randNum = rand() % 1000;
		flag = false;
		if (randNum != 0) {
			for (int j = 2; j < randNum; j++) {

				if (randNum % j == 0) {
					flag = true;

				}
			}
		}
		if (!flag && randNum != 0 && randNum != 1) {
			counterPrime++;
			
		}
	}
	
	cout << counterPrime << endl;



	return 0;
}
