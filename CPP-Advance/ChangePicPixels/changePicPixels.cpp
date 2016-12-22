#include <iostream> 
#include <fstream> 
#include <cstdint> 
using namespace std;

int main(int argc, char* argv[]) {

	if (argc < 3) {
		cout << "Usage: " << "tga.exe input.tga output.tga";
		return 0;
	}



	ifstream file("input.tga", std::ifstream::binary);
	ofstream ofile("output.tga", std::ofstream::binary);
	if (!file.is_open()) {
		cout << "Can't open the file: " << argv[1] << endl;
		return -1;
	}


	if (!file.is_open()) {
		cout << "Can't open the file: " << argv[2] << endl;
		return -1;
	}

	char header[18];
	file.seekg(0, ios::beg);
	file.read(header, 18);

	ofile.seekp(0, ios::beg);
	ofile.write(header, 18);

	file.seekg(12, ios::beg);

	uint16_t width = 0;
	uint16_t height = 0;

	file.read((char *)&width, sizeof(width));
	file.read((char *)&height, sizeof(height));

	char pixel[3];
	file.seekg(18, ios::beg);
	ofile.seekp(18, ios::beg);

	for (int y = 0; y<height / 3; y++)
	{
		for (int x = 0; x<width; x++)
		{
			//cherveno
			pixel[0] = 0;
			pixel[1] = 0;
			pixel[2] = 255;

			ofile.write(pixel, 3);
		}
	}

	for (int y = height / 3; y<2 * height / 3; y++)
	{
		for (int x = 0; x<width; x++)
		{
			//zeleno
			pixel[0] = 0;
			pixel[1] = 255;
			pixel[2] = 0;

			ofile.write(pixel, 3);
		}
	}

	for (int y = 2 * height / 3; y<height; y++)
	{
		for (int x = 0; x<width; x++)
		{
			//bialo
			pixel[0] = 255;
			pixel[1] = 255;
			pixel[2] = 255;

			ofile.write(pixel, 3);
		}
	}

	file.close();
	ofile.close();

	return 0;
}