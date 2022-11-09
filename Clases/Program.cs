
using Clases;
using System.Net.WebSockets;

var carro1 = new Carro("Toyota");
//carro1.Marca = "Toyota";
//carro1.Año = 2003;

//Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

//carro1.Acelerar();

//Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");
Console.WriteLine(carro1.Marca);

//ModificarMarca(carro1);
//Console.WriteLine(carro1.NombreComercial); 

var carro2 = new Carro();
Console.WriteLine(carro2.Marca);
//carro2.Marca = "Mazda";
//carro2.Año = 2019;

//Console.WriteLine(carro2.Marca);

//carro2 = null;


//void ModificarMarca(Carro carro) 
//{
//    carro.Marca += "2";
//}



var calculadora = new Calculadora();
//var resultado = calculadora.CalcularDuploTriplo(3);

//Ejemplo 0: son deconstructor

//var valor = resultado.Valor;
//var duplo = resultado.Duplo;
//var triplo = resultado.Triplo;


//Ejemplo 1: explicita

//int valor, duplo, triplo;
//resultado.Deconstruct(out valor, out duplo, out triplo);


//Ejemplo 2: resumida con deconstruct

//resultado.Deconstruct(out var valor, out var duplo, out var triplo);


//Ejemplo 3: sin usar deconstruct sin usar directamente

//(var valor, var duplo, var triplo) = resultado;


//Ejemplo 4: lo más resumido posible

//var (valor, duplo, triplo) = resultado;

//Console.WriteLine($"El valor es {valor}");
//Console.WriteLine($"El duplo es {duplo}");
//Console.WriteLine($"El triplo es {triplo}");

Console.WriteLine($"Han sido instanciados {Carro.ContadorInstancias} carros");

var (valor, duplo, triplo) = Calculadora.CalcularDuploTriplo(10);
Console.WriteLine($"El valor es {valor}");
Console.WriteLine($"El duplo es {duplo}");
Console.WriteLine($"El triplo es {triplo}");




var mensaje = @"Este es un mensaje,

atentamente, yo";

var cantidadPalabaras = mensaje.ContarPalabras();

Console.WriteLine(cantidadPalabaras);


//patrones de propiedad

//Ejemplo 1:
var apellido = "Carrillo";

if (apellido is { Length: 8 })
{
    Console.WriteLine("La longitud del string es 8");
} else if (apellido is { Length: > 8 }) 
{
    Console.WriteLine("La longitud del string es mayor a 8");
}


//Ejemplo 2:
var carro = new Carro("Toyota");

carro.Año = 2015;

if (carro is { Marca: "Toyota" or "Hyundai", Año: > 2010 })
{
    Console.WriteLine("Es un carrazo");
}
else if (carro is { Marca: "Mercedes", Velocidad: > 25 })
{
    Console.WriteLine("Vas volando pa");
}
else if (carro is { Año: < 2000 }) 
{
    Console.WriteLine("Apenas andas pa");
}


switch (carro)
{
    case
    { Marca: "Toyota" or "Hyundai", Año: > 2010 }:
        Console.WriteLine("Es un carrazo");
        break;
    case
    { Marca: "Mercedes", Velocidad: > 25 }:
        Console.WriteLine("Vas volando pa");
        break;
    case
    { Año: < 2000 }:
        Console.WriteLine("Apenas andas pa");
        break;
}



//Tipos anonimos (classes)

//clase normal
var carro4 = new Carro() { Marca = "Toyota", Año = 2005 };

//Tipo anonimo (clase sin nombre) sus propiedades no se pueden editar
var persona = new { Nombre = "Marco", Apellido = "Carrillo", Edad = 23 };



//structs xd

var puntoA = new Punto(3, 4);

//error
//puntoA = null;


//Esto es valido

var puntoB = new Punto();

Console.WriteLine($"La distancia entre el Punto A y el Punto B es: {puntoA.Distancia(puntoB)}");



//Records == clases == structs


var persona1 = new Persona("Marco", "Carrillo");

var persona2 = new Persona("Marco", "Carrillo");

var sonIguales = persona1 == persona2;

Console.WriteLine($"¿Son los 2 records iguales? {sonIguales}");

persona1 = null;


//Record posicional

var empresa1 = new Empresa("POLybAr", 1989);

//Error: No podemos modificar nombre, es inmutable
//empresa1.Nombre = "Google";

var (Nombre, Año) = empresa1;

Console.WriteLine($"Nombre de la empresa: {Nombre}");
Console.WriteLine($"Año de la empresa: {Año}");



//Clases con propiedades inmutables con init
var clase = new ClaseConPropiedadesInmutables()
{
    Propiedad1 = 42,
    Propiedad2 = "MARCO",
    Propiedad3 = true,
};


//Acceder a valores NULL de una manera segura usando el operador Elvis? tek xd

int[]? arr = { 1, 2 };

arr = null;

Console.WriteLine($"La longitud del arreglo es: {arr?.Length}");



//Operador de Coalescencia Nula xd

//Ejemplo 1: Uso simple

int[]? numeros = new int[] { 1, 2 };

numeros = null;

var conteo = numeros?.Length ?? 0;

Console.WriteLine(conteo);

//Ejemplo 2: Cambiando el valor de una variable

numeros ??= new int[] { };

Console.WriteLine($"¿Es nulo? {numeros is null}");
Console.WriteLine($"¿Es un arrglo vacio? {numeros?.Length == 0}");