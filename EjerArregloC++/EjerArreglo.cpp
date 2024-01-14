#include <iostream>
#include <cctype>
#include <cstdlib>
#include <string>
#include <algorithm>
#include <conio.h>

using namespace std;

int main (){
	int n = 20, suma = 0, Rg1 = 0, Rg2 = 0, Rg3 = 0, Rg4 = 0;
	int nota[n];
	float prom;
	string calif;
	
	cout<<"Calificaciones de notas con Vector"<<endl<<endl;
	
	for(int i = 0; i < n; i++){
	
		cout<<"Ingrese la Nota #" << i+1 <<": ";
		cin>> nota[i]; //cout<<endl;
		
		if (nota[i] == false){
			cout<<endl; cout<<"Valor de Nota incorecta. Las Notas deben de ser numeros enteros. \n\n";
			system("pause");
			//system("cls");
			cin.clear();
			cin.sync(); //identifica todas las letras a la vez
			//cin.ignore(); letra por letra
			i--;
			continue;
		}
	
		
		if(nota[i] < 0 || nota[i] > 100){
			cout<<endl; cout<<"Valor de Nota incorecta. Las Notas deben de ser de 1 a 100\n\n";
			system("pause");
			//system("cls");
			i--;
			
		
		}else if(nota[i] >= 90){   //Escala de calificaciones
			Rg1++;
			
		}else if(nota[i] >= 80 && nota[i] <= 89){
			Rg2++;
		
		}else if(nota[i] >= 70 && nota[i] <= 79){
			Rg3++;
		
		}else{
			Rg4++;	
		}	
	}
	
	//acumulador de las notas
	for(int i = 0; i < n; i++){
		suma += nota[i];
	}
	
	//Calculos de los promedios
	prom = (float)suma /n;
	
	cout<<endl; cout<<"-----------------Resultado Final de Estudiante--------------------\n\n";
	
	cout<<endl; cout<<"Promedio de las Notas "<<prom<<endl;
	
	//calificacion con letras de los promedios
	if(prom >= 90){
		calif = "A";
		cout <<"Pasa en " << calif <<". Esta Aprobado"<<endl <<endl;
	
	}else if(prom >= 80 && prom <= 89){
		calif = "B";
		cout <<"Pasa en " << calif <<". Esta Aprobado"<<endl <<endl;

	}else if(prom >= 70 && prom <= 79){
		calif = "C";
		cout <<"Pasa en " << calif <<". Esta Aprobado"<<endl <<endl;
	
	}else{
		calif = "F";
		cout <<"Pasa en " << calif << ". Esta Reprobado"<<endl <<endl;
	}
	
	//Para contar los notas de acuerdo a las calificaciones
	cout<<"Resultados de las Notas ya calificadas\n\n";
	cout <<"Notas entre 1 a 69: " << Rg4 <<endl;
	cout <<"Notas entre 70 a 79: " << Rg3 <<endl;
	cout <<"Notas entre 80 a 89: " << Rg2 <<endl;
	cout <<"Notas entre 90 a 100: " << Rg1 <<endl;
	
	getch();
	return 0;
}
