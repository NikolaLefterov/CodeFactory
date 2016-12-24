//imoti.h
#ifndef _IMOTI_H
#define _IMOTI_H
#include<string>
class Realestate {
private:
	char * name;
	char * adress;
	double kvadratyra;
	double cena_kv_m;
public:
	Realestate();
	Realestate(char*, char*, double, double);
	~Realestate();
	void set_name(char*);
	void set_adres(char*);
	void set_kvadratura(double);
	void set_cena_kv_m(double);
	char * get_name()const;
	char * get_adress()const;
	double get_kvadratyra()const;
	double get_cena_kv_m()const;
	void read();
	void print();
	double all()const;
};
#endif

//imoti.cpp

#include <iostream>
#include "imoti.h"
#include<cstring>
using namespace std;

Realestate::Realestate() {
	name = new char[2];
	name = " ";
	adress = new char[2];
	adress = " ";
	kvadratyra = 0.;
	cena_kv_m = 0.;
}
Realestate::Realestate(char*name, char*adress, double k, double c) :kvadratyra(k),
cena_kv_m(c) {
	this->name = new char[strlen(name) + 1];
	strcpy_s(this->name, strlen(name), name);
	this->adress = new char[strlen(name) + 1];
	strcpy_s(this->adress, strlen(adress), name);
}
Realestate::~Realestate() {
	delete[]name;
	delete[]adress;
}
void Realestate::set_name(char* name) {
	this->name = new char[strlen(name) + 1];
	strcpy_s(this->name, strlen(name), name);

}
void Realestate::set_adres(char* adress) {
	this->adress = new char[strlen(name) + 1];
	strcpy_s(this->adress, strlen(adress), name);
}
void Realestate::set_kvadratura(double k) {
	kvadratyra = k;
}
void Realestate::set_cena_kv_m(double c) {
	cena_kv_m = c;
}
char * Realestate::get_name()const {
	return name;
}
char * Realestate::get_adress()const {
	return adress;
}
double Realestate::get_kvadratyra()const {
	return kvadratyra;
}
double Realestate::get_cena_kv_m()const {
	return cena_kv_m;
}
void Realestate::read() {
	cout << "Please, enter name: ";
	name = new char[100];
	cin.getline(name, 99);
	cout << "Please ,enter address: ";
	adress = new char[100];
	cin.getline(adress, 99);
	cout << "Please, enter square: ";
	cin >> kvadratyra;
	cout << "square meter: ";
	cin >> cena_kv_m;
	cin.ignore();
}
void Realestate::print() {
	cout << "Name: " << name << std::endl;
	cout << "Address: " << adress << std::endl;
	cout << "Square: " << kvadratyra << std::endl;
	cout << "Square meter price: " << cena_kv_m << std::endl;
}
double Realestate::all()const {
	return kvadratyra*cena_kv_m;
}

//main.cpp

#include <iostream>
#include"imoti.h"
#include<cstring>
using namespace std;

int main()
{
	//setlocale(LC_ALL, "Bulgarian");
	size_t n = 5;
	int br = 0;
	double sum = 0;
	Realestate* kushta = new Realestate[n];
	for (int i = 0; i <n; i++)
	{
		kushta[i].read();
	}
	for (int i = 0; i <n; i++)
	{
		kushta[i].print();
		cout << "Price of square meter is: " << kushta[i].all() << endl;
	}
	for (int i = 0; i <n; i++)
	{
		double max = 0;
		sum += kushta[i].all();
		if (kushta[i].all()>max)
		{
			br = i;
			max = kushta[i].all();
		}
	}
	cout << "Maximal price is " << kushta[br].all() << endl;
	cout << "Sum of all prices is " << sum << endl;
	return 0;
}
