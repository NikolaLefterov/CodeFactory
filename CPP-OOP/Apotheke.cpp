
//Apteka.h
using namespace std;
#ifndef _APTEKA_H
#define _APTEKA_H
#include <iostream>
#include <string>
#include <fstream>
using namespace std;

class Suplyer
{
public:
	Suplyer();
	Suplyer(string, string, string);
	~Suplyer();
	void read();
	void print();
private:
	string name_dos;
	string adress_dos;
	string tel_dos;
};
class Maker
{
public:
	Maker();
	Maker(string, string, string);
	~Maker();
	void read();
	void print();

private:
	string name_pr;
	string adress_pr;
	string tel_pr;
};

class Importer
{
public:
	Importer();
	Importer(string, string, string);
	~Importer();
	void read();
	void print();

private:
	string name_vn;
	string adress_vn;
	string tel_vn;
};

class drug :public Suplyer, public Maker
{
public:
	drug();
	drug(string, string, string, string, string, string, string, double, unsigned);
	~drug();
	void print();
	void read();
private:
	string name_lek;
	double price_lek;
	unsigned quantity_lek;


};

class Apteka : public Importer, public drug {
public:
	Apteka();
	Apteka(string, string, string, string, string, string, string, string, string, string, string, string, string, double, unsigned);
	~Apteka();
	void read();
	void print();

private:
	string name;
	string adress;
	string tel;

};
#endif
//apteka.cpp
#include "Apteka.h"

Suplyer::Suplyer() {
}
Suplyer::Suplyer(string n, string a, string t) :name_dos(n),
adress_dos(a), tel_dos(t) {
}
Suplyer::~Suplyer() {
}
void Suplyer::read() {
	cout << "Enter suplyer name : " << endl;
	getline(cin, name_dos);
	cout << "Enters suplyer address : " << endl;
	getline(cin, adress_dos);
	cout << "Enter Suplyer telephone :\n";
	cin >> tel_dos;
	cin.ignore();
}
void Suplyer::print() {
	cout << "Suplyer's name :" << name_dos << " ; Address : " << adress_dos << " and telephone: " << tel_dos << endl;
}

Maker::Maker() {}
Maker::Maker(string n_p, string a_p, string t_p) :name_pr(n_p),
adress_pr(a_p), tel_pr(t_p)
{
}
Maker::~Maker() {}
void Maker::read() {
	cout << "Enter Maker's name :" << endl;
	getline(cin, name_pr);
	cout << "Enter Maker's address :" << endl;
	getline(cin, adress_pr);
	cout << "Enter Maker's phone number :" << endl;
	cin >> tel_pr;
	cin.ignore();
}
void Maker::print() {
	cout << "Maker's name :" << name_pr << " ; Address : " << adress_pr << " and telephone: " << tel_pr << endl;

}

Importer::Importer() {}
Importer::Importer(string n, string a, string t) :name_vn(n),
adress_vn(a), tel_vn(t)
{
}
Importer::~Importer() {}
void Importer::read() {
	cout << "Enter Importer name :" << endl;
	getline(cin, name_vn);
	cout << "Enter Importer address :" << endl;
	getline(cin, adress_vn);
	cout << "Enter Importer telephone :" << endl;
	cin >> tel_vn;
	cin.ignore();
}
void Importer::print() {
	cout << "Suplyer's name :" << name_vn << " ; Address : " << adress_vn << " and telephone: " << tel_vn << endl;
}
drug::drug() {}
drug::drug(string n, string nd, string ad, string td, string np, string ap, string tp, double p, unsigned q) :
	Suplyer(nd, ad, td), Maker(np, ap, tp), name_lek(n), price_lek(p), quantity_lek(q) {
}
drug::~drug() {}
void drug::print() {
	cout << "Drug \"" << name_lek << "\" is suplyed from: " << endl;
	Suplyer::print();
	cout << "Drug \"" << name_lek << "\" is produced from: " << endl;
	Maker::print();
	cout << "price : " << price_lek << endl;
	cout << "quantity: " << quantity_lek << endl;
}
void drug::read() {
	cout << "enter name of the drug: " << endl;
	getline(cin, name_lek);
	cout << "enter price of the drug: " << endl;
	cin >> price_lek;
	cout << "enter quantity: " << endl;
	cin >> quantity_lek;
	cin.ignore();
	Suplyer::read();
	Maker::read();
}


Apteka::Apteka() {}
Apteka::Apteka(string n_a, string ad_a, string tel_a, string nv, string av, string tv, string n, string nd, string ad, string td, string np, string ap, string tp, double p, unsigned k)
	:Importer(nv, av, tv), drug(n, nd, ad, td, np, ap, tp, p, k), name(n_a), adress(ad_a), tel(tel_a) {
}
Apteka::~Apteka() {}
void Apteka::read() {
	cout << "Enter name of the apotheke : " << endl;
	getline(cin, name);
	cout << "Enter address of the apotheke: " << endl;
	getline(cin, adress);
	cout << "Enter telephone for the apotheke : " << endl;
	cin >> tel;
	cout << "Drugs on the stock : " << endl;
	cin.ignore();
	drug::read();
	Importer::read();
}
void Apteka::print() {
	cout << "Apotheke : " << name << " with address : " << adress << ";  and telephone : " << tel << endl <<
		"got drug: " << endl;
	drug::print();
	Importer::print();
}
//main.cpp

#include "apteka.h"

int main() {
	Apteka apteka;
	apteka.read();
	unsigned tmp;
	cout << "How many more drugs are on the stock? ";
	cin >> tmp;
	drug * arr = new drug[tmp];
	Importer * arr_1 = new Importer[tmp];
	for (size_t i = 0; i < tmp; i++)
	{
		arr[i].read();
		arr_1[i].read();
	}
	cout << "____________________________________" << endl;
	apteka.print();
	cout << "____________________________________" << endl;
	for (size_t i = 0; i < tmp; i++)
	{
		arr[i].print();
		arr_1[i].print();
	}
	delete[]arr_1;
	delete[]arr;
	return	0;
}
