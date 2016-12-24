//student.h

#pragma once
#ifndef _STUDENT_H
#define _STUDENT_H
#include<string>
struct student
{
	std::string fnum;
	std::string name;
	double grade;

};
int fillStudent(student &);
int fillArrStudent(student*, unsigned);
int printStudent(const student &);
int printArrStudent(const student*, unsigned);
int printExcellentStudent(student *, unsigned);
unsigned countPoorStudent(student *, unsigned);
#endif


//student.cpp

#include <iostream>
//#include <clocale>
//#include <cmath>
//#include <ctime>
#include<cstring>
#include "student.h"

using std::cout;
using std::cin;
using std::string;
using std::endl;

int fillStudent(student& s) {
	cout << "Enter F number of the student";
	cin >> s.fnum;
	cout << "Enter name of the student: ";
	cin.ignore();
	getline(cin, s.name);
	cout << "Enter avarage grade of the student: ";
	cin >> s.grade;
	return 0;
}

int fillArrStudent(student*arr, unsigned n) {
	for (int i = 0; i < n; i++)
		fillStudent(arr[i]);
	return 0;
}

int printStudent(const student& s) {
	cout << "Fnum: " << s.fnum << endl;
	cout << "name: " << s.name << endl;
	cout << "Grade: " << s.grade << endl;
	return 0;
}

int printArrStudent(const student* arr, unsigned n) {
	for (int i = 0; i < n; i++)
		printStudent(arr[i]);

	return 0;
}
int printExcellentStudent(student *arr, unsigned n) {
	for (int i = 0; i < n; i++)
	{
		if (arr[i].grade >= 5.5)
			printStudent(arr[i]);
	}
	return 0;
}
unsigned countPoorStudent(student *arr, unsigned n) {
	unsigned cnt = 0;
	for (int i = 0; i < n; i++) {
		if (arr[i].grade < 3)cnt++;
	}
	return cnt;
}


//main.cpp

#include <iostream>
#include <clocale>
//#include <cmath>
//#include <ctime>
#include<cstring>
#include "student.h"
using namespace std;

int main()
{
	//setlocale(LC_ALL, "Bulgarian");
	unsigned szn;
	cout << "How many students the program will have?: ";
	cin >> szn;
	student *arr = new student[szn];

	cout << "Enter the students data: " << endl;
	fillArrStudent(arr, szn);
	cout << "Print all students: " << endl;
	printArrStudent(arr, szn);
	cout << "print Excellent Students : " << endl;
	printExcellentStudent(arr, szn);
	cout << "print Poor Student" << endl;
	countPoorStudent(arr, szn);


	delete[] arr;
	return 0;
}
