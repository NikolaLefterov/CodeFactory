#include <iostream>
#include <string>
using namespace std;
typedef struct Element * po;
struct Element {
	string data;
	po next;
};

int main() {
	po na = NULL;
	po p = NULL;
	po q = NULL;
	string danna;
	while (cin >> danna) {
		p = new Element;
		p->data = danna;
		p->next = na;
		na = p;
		//if (danna[danna.length() - 1] == 'n') {
		//	break;
		//}
		if (cin.get() == '\n') {
			break;
		}
	}
		

	
	
	//na = na->next;
	p = na;
	while (p != NULL) { //p->next != NULL - ne razpechatva posledniq
		cout << p->data << endl;
		p = p->next;
	}

	delete p;
	system("pause");
	return 0;
}
