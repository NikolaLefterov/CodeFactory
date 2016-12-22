#include <iostream>
#include <cstdlib>
#include <fstream>
#include <string>

using namespace std;

int main() {
	ifstream file;
	string fname;
	bool flag = false;
	do {
		try {
			cout << "Enter file name: ";
			getline(cin, fname);
			file.open(fname);
			if (!file) {
				flag = true;
				throw exception(string("File " + fname + " not found!").c_str());
			}
			else {
				flag = false;
			}
		}
		catch (exception & e) {
			cerr << e.what() << endl << typeid(e).name() << endl;
		}
	} while (flag);
	string line;
	unsigned int br = 1;
	while (getline(file, line))
	{
		cout << br++ << ": " << line << endl;
	}
	//file.close();
	//file.open(fname);
	file.clear();
	file.seekg(0, ios::beg);
	ofstream fout("source.txt");
	if (!fout) {
		cerr << "Could not open or create file source.txt!\n";
		return 1;
	}
	br = 1;
	while (getline(file, line))
	{
		fout << br++ << ": " << line << endl;
	}
	file.close();
	fout.close();

	fstream fs("source.txt", ios::in | ios::out);
	if (!fs) {
		cerr << "File source.txt could not be opned!\n";
		return 2;
	}

	cout << endl << endl << "Printing content of source.txt: \n";
	unsigned tmp = br;
	br = 1;
	fs.seekp(0, ios::beg);
	while (tmp != br) {

		if (br < 10) {
			fs.put('d').put('d');
			//fs << "  ";k
			//fs.write("  ");
			//change 2 chars from file
		}
		else if (br < 100) {
			fs.put('d').put('d').put('d');
			//change 3 chars from file
		}
		else {
			fs.put('d').put('d').put('d').put('d');
			//change 4 chars
		}
		
		fs.seekg(fs.tellp());
		getline(fs, line);
		fs.seekp(fs.tellg());
		br++;

	}
	fstream prnsource;
	prnsource.open("source.txt", ios::in);

	if (prnsource.is_open())
	{
		string s;
		while (getline(prnsource, s))
		{
			cout << s << endl;
			
		}
		prnsource.close();
	}
	else
		cout << "Error invalid file name!!! "<< endl;
	return 0;
}
