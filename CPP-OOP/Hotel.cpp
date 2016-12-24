//hotel.h
#pragma once
class Room {
public:
	Room(size_t = 0, int* = 0,double* = 0);
	Room(const Room&);
	~Room();
	Room& operator=(const Room&);
	void print()const;
	void newRegistry(int, double);
	int maxSum();
	double maxSumAllRoom();
private:
	size_t n;
	int * numbers;
	double * price;
};
//hotel.cpp
#include "hotel.h"
#include <iostream>
#include <cassert>

Room::Room(size_t n, int *nm, double *sm):n(n),numbers(new int(n)), price(new double(n))
{
	assert(numbers != NULL);
	assert(price != NULL);
	for (size_t i = 0; i < n; i++)
	{
		numbers[i] = nm[i];
		price[i] = sm[i];
	}
}

Room::Room(const Room &h)
{
	n = h.n;
	numbers = new int[n];
	assert(numbers != NULL);
	price = new double[n];
	assert(price != NULL);
	for (size_t i = 0; i < n; i++)
	{
		numbers[i] = h.numbers[i];
		price[i] = h.price[i];
	}
}

Room::~Room()
{
	delete[]price;
	delete[]numbers;
}

Room & Room::operator=(const Room &h)
{
	if (this != &h) {
		n = h.n;
		if (numbers != NULL) delete[]numbers;
		numbers = new int[n];
		assert(numbers != NULL);
		if (price != NULL) delete[]price;
		price = new double[n];
		assert(price != NULL);
		for (size_t i = 0; i <n; i++)
		{
			numbers[i] = h.numbers[i];
			price[i] = h.price[i];
		}
	}
	return *this;
}

void Room::print() const
{
	std::cout << "All reservations for the room \n";
	for (size_t i = 0; i < n; i++)
	{
		std::cout << "reservation number: " << numbers[i] << " price= " << price[i] << std::endl;
	}
}

void Room::newRegistry(int nm, double sm)
{
	if (n == 0) {
		n = 1;
		numbers = new int[n];
		numbers[0] = nm;
		price = new double[n];
		price[0] = sm;
	}
	else {
		n++;
		int* _numbers = new int[n];
		double* _price = new double[n];
		for (size_t i = 0; i < n-1; i++)
		{
			_numbers[i] = numbers[i];
			_price[i] = price[i];
		}
		_numbers[n - 1] = nm;
		_price[n - 1] = sm;
		delete[]numbers;
		delete[]price;
		numbers = _numbers;
		price = _price;
	}
}

int Room::maxSum()
{
	int room = 0;
	double max = 0;
	max = price[0];

	for (size_t i = 1; i < n; i++)
	{
		if (max < price[i]) {
			max = price[i];
			room = i;
		}
	}
	std::cout << "max sum= " << max << " room number: " << numbers[room] << std::endl;
	return 0;
}

double Room::maxSumAllRoom()
{
	double sum = 0;
	for (size_t i = 0; i < n; i++)
	{
		sum += price[i];
	}
	return sum;
}
//main.cpp
#include "hotel.h"
#include <iostream>

using namespace std;

int main() {
	Room a;
	for (size_t i = 0; i < 5; i++)
	{
		a.newRegistry(rand() % 10000 + 25, (((double)rand() / RAND_MAX)*210. + 50));
	}
	a.print();
    a.maxSum();
	cout << "The maximum price of all rooms is: " << a.maxSumAllRoom() << endl;
}