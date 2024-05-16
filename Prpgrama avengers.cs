/******************************************************************************
autores= santiago alvarez, diana carolina
fecha= 16.05.

Los Avengers necesitan un programa en C# para calcular la fuerza
necesaria para levantar um objeto en el planeta Marte. Completa el
espacio en blanco para solicitar al usuario la masa del objeto
a levantar:
Formula: Fuerza = masa * gavedad 
*******************************************************************************/
using System;
class Programa
{
  static void Main( string[] args) 
  {
     // definimos la gravedad en marte en m/s^2
     double gravedad = 3.72076;
     
    Console.WriteLine("ingrese la mas del objeto a levantar en kilogramos:");

    double masaObjeto = Convert.ToDouble(Console.ReadLine());
    double fuerza = masaObjeto * gravedad;
    
   Console.WriteLine("La fuerza necesaria para levantar el objeto es de aproximadamente"  + fuerza + "Newtons");
    
     }
}