//Rectangle.h
#pragma once
#include <iostream>
class Rectangle{
	friend 	std::ostream& operator<<(std::ostream&, const Rectangle &);
	friend Rectangle operator+(const Rectangle &x, int);
private:
	int a, b;
public:
	Rectangle(unsigned =0, unsigned =0);
	~Rectangle();
	unsigned set_a(unsigned = 0);
	unsigned set_b(unsigned = 0);
	unsigned get_a()const;
	unsigned get_b()const;
	void read();
	



};
std::ostream& operator<<(std::ostream&, const Rectangle &);
Rectangle operator+(const Rectangle &x, int );

//Rectangle.cpp
#include "Rectangle.h"
#include <iostream>
using namespace std;
Rectangle::Rectangle(unsigned a, unsigned b):a(a),b(b){
}

Rectangle::~Rectangle()
{
}

unsigned Rectangle::set_a(unsigned a)
{
	this->a = a;
	return 0;
}

unsigned Rectangle::set_b(unsigned b)
{
	this->b = b;
	return 0;
}

unsigned Rectangle::get_a() const
{
	return a;
}

unsigned Rectangle::get_b() const
{
	return b;
}

void Rectangle::read()
{
	do
	{
	cout << "въведете а= ";
	cin >> a;
	cout << "въведете b= ";
	cin >> b;
	} while (a<0||b<0);
}
Rectangle operator+(const Rectangle & x, int v)
{
	return Rectangle(x.a+v,x.b+v);
}
std::ostream & operator<<(std::ostream & out , const Rectangle & x)
{
	return out << "a+2=" << x.a << " b+2= " << x.b;
}

//main.cpp
#include <iostream>
#include "Rectangle.h"
using namespace std;

int main() {
	setlocale(LC_ALL, "Bulgarian");

	Rectangle a,b;
	a.read();
	cout << a+2 << endl;
	return 0;
}
