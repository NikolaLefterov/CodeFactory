
//Planet.h

#pragma once
#include <fstream>
#ifndef _PLANET_H
#define _PLANET_H
#include<string>
struct planet
{
	std::string name;
	long double razstoqnie;
	double diametur;
	double masa;
	std::ofstream gabi;
};
int fillPlanet(planet &);
int fillArrPlanet(planet *, unsigned);
int printPlanet(const planet &);
int printArrPlanet(const planet*, unsigned);
int printRazstoqnie(const planet*, unsigned);
int printSeverePlanet(planet *, unsigned);
int printSmallDiameter(planet *, unsigned);
int printFarthestPlanet(planet *, unsigned);
int printNamePlanet(const planet*, unsigned);
int printPlanet2(planet*, unsigned);

#endif


//PLANET.CPP

#include <iostream>
#include <fstream>
#include <clocale>
//#include <cmath>
//#include <ctime>
#include<cstring>
#include "Planet.h"
std::ofstream planetStream;
using std::cout;
using std::cin;
using std::string;
using std::endl;
//string nov;
int fillPlanet(planet& p) {
	planetStream.open("planets.txt");
	planetStream << "Enter name of the planet: ";
	cout << "Enter name of the planet: ";
	cin >> p.name;
	planetStream << p.name;
	cout << "Enter distance to the sun: ";
	cin.ignore();
	cin >> p.razstoqnie;
	cout << "Enter square of the planet: ";
	cin >> p.diametur;
	cout << "Enter weight of the planet: ";
	cin >> p.masa;
	return 0;
}
int fillArrPlanet(planet *arr, unsigned n) {
	for (int i = 0; i < n; i++) {
		fillPlanet(arr[i]);
		cout << "-------------------------------" << endl;
	}
	return 0;
}
int printPlanet(const planet& p) {
	cout << "Planet: " << p.name << endl;
	cout << "Distance to the sun: " << p.razstoqnie << endl;
	cout << "Square of the planet: " << p.diametur << endl;
	cout << "Weight of the planet: " << p.masa << endl;
	return 0;
}
int printArrPlanet(const planet* arr, unsigned n) {
	for (int i = 0; i < n; i++) {
		printPlanet(arr[i]);
		cout << endl;
	}
	return 0;
}
double razstoqnie(const planet &p) {

	int v = 300000;
	double t = p.razstoqnie / v;
	return t;
}
int printRazstoqnie(const planet* arr, unsigned n) {
	for (int i = 0; i < n; i++) {
		cout << "Planet: " << arr[i].name << endl;
		cout << "How much seconds needs the light to travel from the sun to the planet: " << razstoqnie(arr[i]) << endl;
	}
	cout << endl;
	return 0;
}
int printSeverePlanet(planet *arr, unsigned n) {
	int i;
	double br = 0;
	int broqch = 0;
	for (i = 0; i < n; i++)
	{
		if (arr[i].masa > br) {
			br = arr[i].masa;
			broqch = i;
		}
	}
	cout << "Planet: " << arr[broqch].name << endl;
	cout << "Weight: " << arr[broqch].masa << endl;
	cout << endl;
	return 0;
}
int printSmallDiameter(planet *arr, unsigned n) {
	int i;
	double br = 0;
	int broqch = 0;
	for (i = 0; i < n; i++)
	{
		if (arr[i].diametur > br) {
			br = arr[i].diametur;
			broqch = i;
		}
	}
	for (i = 0; i < n; i++)
	{
		if (arr[i].diametur < br) {
			br = arr[i].diametur;
			broqch = i;
		}
	}
	cout << "Planet: " << arr[broqch].name << endl;
	cout << "Square: " << arr[broqch].diametur << endl;
	cout << endl;
	return 0;
}
int printFarthestPlanet(planet *arr, unsigned n) {
	int i;
	double br = 0;
	int broqch = 0;
	for (i = 0; i < n; i++)
	{
		if (arr[i].razstoqnie > br) {
			br = arr[i].razstoqnie;
			broqch = i;
		}
	}
	cout << "Planet: " << arr[broqch].name << endl;
	cout << "Distance to the sun: " << arr[broqch].razstoqnie << endl;
	cout << endl;
	return 0;
}
int printNamePlanet(const planet* arr, unsigned n) {
	for (int i = 0; i < n; i++) {
		if (n - 1 == i) {
			cout << arr[i].name << ".!" << endl;
		}
		else {
			cout << arr[i].name << ", ";
		}
	}
	return 0;
}
int printPlanet2(planet* arr, unsigned n) {
	int a;
	int c = 0;
	string b;
	int i = 0, j = 1;
	while (c <= n)
	{
		for (int i = 0, j = 1; i < n, j<n; i++, j++)
		{
			if (arr[i].razstoqnie >arr[j].razstoqnie) {
				a = arr[i].razstoqnie;
				arr[i].razstoqnie = arr[j].razstoqnie;
				arr[j].razstoqnie = a;

				b = arr[i].name;
				arr[i].name = arr[j].name;
				arr[j].name = b;
			}
		}c++;
	}

	for (int i = 0; i < n; i++) {
		cout << arr[i].name << " Distance to the sun: " << arr[i].razstoqnie << endl;
	}
	cout << endl;
	return 0;
}

//main.cpp


#include <iostream>
#include<cstring>
#include <fstream>
#include "Planet.h"
using namespace std;

int main()
{

	//setlocale(LC_ALL, "Bulgarian");
	int szn;
	cout << "How much Planets? : ";
	cin >> szn;
	planet *arr = new planet[szn];
	unsigned menu;
	do
	{
		cout << "Please select operations: " << endl;
		cout << "1 – Enter data for the planets " << endl;
		cout << "2 – Print the time for the light to travel from the sun to the planet: " << endl;
		cout << "3 – Print the most heaviest planet " << endl;
		cout << "4 – Print the planet with the smallest square " << endl;
		cout << "5 – Print the most far away from the sun planet " << endl;
		cout << "6 – Print the whole list of the planets " << endl;
		cout << "7 – Print all planets sorted by the distance to the sun " << endl;
		cout << "0 – Stop program " << endl;
		cin >> menu;
		cout << endl;
		switch (menu)
		{
		case 1:
			fillArrPlanet(arr, szn);
			printArrPlanet(arr, szn);
			break;
		case 2:
			printRazstoqnie(arr, szn);
			break;
		case 3: cout << "Most heaviest planet is : " << endl;
			printSeverePlanet(arr, szn);
			break;
		case 4: cout << "Planet with the smallest square is: " << endl;
			printSmallDiameter(arr, szn);
			break;
		case 5: cout << "The most far away planet from the sun is: " << endl;
			printFarthestPlanet(arr, szn);
			break;
		case 6: cout << "All planets are: " << endl;
			printNamePlanet(arr, szn);
			break;
		case 7: cout << "Print all planets sorted by the distance to the sun: " << endl;
			printPlanet2(arr, szn);
			break;
		default:
			break;
		}
	} while (menu != 0);
	delete[] arr;
	//system("PAUSE");		system("PAUSE");
	return 0;
}