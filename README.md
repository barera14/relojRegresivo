
#include <iostream>

using namespace std;
int main()
{
  std::string name;
 int  NumMuestras;
 float contMuestras;
 float contPesoVol;
 int i;
 float  humedad;
 float DenAbsRel;
 float peso;
 float pesoVol;
 	float n1;
 	 float G1;
 float Vt1;
 float Vs;
 float Vt;
 float Vv;
 float e;
 float n;
 float G;
 float promPororidad;
 float sumPorosidad;
 float sumSatMuestras;
 float promSatMuestras;
 float porE;
 float porVolV;
 float nmuestra;
cout<<"Ingresa el numero de muestras:"<<endl;
cin>>NumMuestras;
nmuestra=(float)NumMuestras;
for(i=1; i<=NumMuestras; i++){
    cout<<"Muestra #"<<i<<endl;
	cout<<"Ingrese la humedad de la muestra numero "<<i<<endl;
	cin>>humedad;
	cout<<"Ingrese la densidad absoluta relativa de la muestra numero "<<i<<endl;
	cin>>DenAbsRel;
	cout<<"Ingrese el peso de la muestra numero "<<i<<endl;
	cin>>peso;
    cout<<"Ingrese el peso volumetrico de la muestra numero "<<i<<endl;
	cin>>pesoVol;
	Vs=peso/DenAbsRel;
	Vt1=peso+humedad;
	Vt=Vt1/pesoVol;
	Vv=Vt-Vs;
    if(Vv>20&&Vv<30){
        porVolV=porVolV+1;
    }
	e=Vv/Vs;
	if(e>0.5 && e<0.8){
	    porE=porE+1;
	}
	
	 n1=e/(1+e);
	n=n1*100;
	sumPorosidad=sumPorosidad+n;
     G1=humedad/Vv;
    G=G1*100;
    sumSatMuestras=sumSatMuestras+G;
    cout<<"el valor del volumen de los solidos es "<<Vs<<endl;
	cout<<"el valor del volumen total "<<Vt<<endl;
	cout<<"el valor del volumen vacio"<<Vv<<endl;
	cout<<"el valor de la relación de vacios de la arcilla es "<<e<<endl;
	cout<<"el valor de la porosidad "<<n<<endl;
	cout<<"el valor de grado de saturacion es "<<G<<endl;
	if(humedad>7.0){
	    contMuestras=contMuestras+1.0;
	}
	if(pesoVol<1.6){
	    contPesoVol=contPesoVol+1;
	}
	
}
promPororidad=sumPorosidad/nmuestra;
promSatMuestras=sumSatMuestras/nmuestra;
float porc1;
float porc2;
porc2=porE/nmuestra;
porc1=porc2*100;
float porVv;
float porVv2;
porVv2=porVolV/nmuestra;
porVv=porVv2*100;
	cout<<"Numero de muestras que tuvieron humerdad superior a 7 es: "<<contMuestras<<endl;
	cout<<"Numero de muestras que tuvieron peso volumetricos inferiores a 1,6 es:"<<contPesoVol<<endl;
	cout<<"Promedio de porosidad de muestras registradas es:"<<promPororidad<<endl;
	cout<<"Promedio de grado de saturacion de las muestras registradas es: "<<promSatMuestras<<endl;
	cout<<"Porcentaje de muestras que obtuvieron valores de relacion de vacio entre 0.5 y 0.8 es:  "<<porc1<<"%"<<endl;
	cout<<"Porcentaje de muestras que obtuvieron valores de volumen de vacio entre 20 y 30 es: "<<porVv<<"%"<<endl;
}
