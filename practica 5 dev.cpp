#include <iostream>
int main() {
	using namespace std;
	int choose =1 ;
	while (choose ==1) {
		int b;
		cout << "ingrese un numero para verificar si es par o impar" << endl;
		cin >> b;
		if (b%2 == 0) {
			cout << " el numero es par" << endl;
		} 
		else { 
		cout << " numero es impar" << endl;
		}
		cout << "para verificar mas: 1 para si y 0 para no" << endl;
		cin >> choose;
	}
	cout << "todos los numeros estan verificados" << endl;
	return 0;
}
