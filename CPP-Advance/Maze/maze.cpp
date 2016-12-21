#include <iostream>
using namespace std;
#define FALSE 0
#define TRUE 1

#define NROWS 10
#define MCOLS 21

// Symbols:
// '0' = open
// 'S' = start
// 'G' = goal
// '+' = path
// 'x' = bad path
char maze[NROWS][MCOLS] = {
	"S0111111111111111111",
	"00000000000000000001",
	"10111111101011111101",
	"10000000101010110101",
	"10111111101010110101",
	"1010000G000010110101",
	"10101110111110110001",
	"10101010100000110101",
	"1000100001000000001",
	"11111111111111111111"

};



void display_maze(void);
int find_path(int x, int y);


int
main(void)
{
	display_maze();

	if (find_path(0, 0) == TRUE)
		cout <<"Success!\n";
	else
		cout << "Failed\n";

	display_maze();

	return 0;
}



void
display_maze(void)
{
	

	cout <<"MAZE:\n";
	for (int i = 0; i < NROWS; i++)
		cout << maze[i] << endl; 
	cout << endl;

	return;
}


int
find_path(int x, int y)
{

	if (x < 0 || x > MCOLS - 1 || y < 0 || y > NROWS - 1) return FALSE;


	if (maze[y][x] == 'G') return TRUE;


	if (maze[y][x] != '0' && maze[y][x] != 'S') return FALSE;


	maze[y][x] = '+';


	if (find_path(x, y - 1) == TRUE) return TRUE;


	if (find_path(x + 1, y) == TRUE) return TRUE;


	if (find_path(x, y + 1) == TRUE) return TRUE;


	if (find_path(x - 1, y) == TRUE) return TRUE;


	maze[y][x] = 'x';

	return FALSE;
}
