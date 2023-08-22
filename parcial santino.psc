
Algoritmo parcial
	Definir largo Como Entero;
	Definir altura Como Entero;
	Definir ancho Como Entero;
	Definir cantidaddeprisma Como Entero;
	Definir areabase Como Real;
	Definir areaaltura Como Real;
	Definir areaancho Como Real;
	Definir calcularbase, calcularaltura, calcularancho Como Real;
	escribir Sin Saltar "ingrese valor del largo";
	Leer largo;
	Escribir Sin Saltar"ingrese el valor de la altura";
	Leer altura;
	Escribir Sin Saltar "ingrese el ancho";
	Leer ancho;
	cantidaddeprisma=0;
	Repetir
		
	 
	Si largo>0 Entonces
	calcularbase=ancho*altura;
	SiNo
		Escribir Sin Saltar"ingrese un numero mayor a 0";
	Fin Si
	Si altura>0 Entonces
		calcularaltura=altura*ancho;
	SiNo
		Escribir Sin Saltar "ingrese un numero mayor a 0";
	FinSi
	Si ancho>0 Entonces
		calcularancho=altura*largo;
	SiNo
		Escribir Sin Saltar"ingrese un numero mayor a 0";
	Fin Si
Hasta Que cantidaddeprisma=0;
Escribir "cantida de prisma ingresados " cantidaddeprisma+1;
FinAlgoritmo 
