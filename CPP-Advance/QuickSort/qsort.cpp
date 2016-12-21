
#include <iostream>
	using namespace std;

void quickSort(int * numbers, int l, int r) {
	int j = l;
	int k = r;
	int buff;
	int middle = numbers[(j + r) / 2];

	if (r > l) {
		cout << "Sinking! Left index " << l << " and right index " << r << "\n";
		do {
			while (numbers[j] < middle) j++;
			while (numbers[k] > middle) k--;

			if (j <= k) {
				buff = numbers[j];
				numbers[j] = numbers[k];
				numbers[k] = buff;
				j++;
				k--;
			}
		} while (j <= k);

		quickSort(numbers, l, k);
		quickSort(numbers, j, r);
	}
	else
		cout << "merging!!! Left index " << l << " and right index " << r << "\n";
}

int main() {
	cout << "how long should be the array" << endl;
	int n = 0;
	cin >> n;
	int * arr = new int[n];
	for (int i = 0; i < n; i++) {
		arr[i] = n - i;
	}
	cout << "Array before qsort:" << endl;;
	for (int i = 0; i < n; i++) {
		cout << arr[i] << " ";
	}
	cout << endl << endl;

	quickSort(arr, 0, n - 1);
	cout << "\nArray after qsort : ";
	for (int i = 0; i < n; i++) {
		cout <<arr[i] << " ";
	}

	return 0;
}


