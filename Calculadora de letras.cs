/******************************************************************************

Autor: Diana Carolina

Fecha: 18/07/24

Descripcion: Calculadora para frases que incluyan un menu para regresar 
a opcion debe permitir ingresar la frase y luego calcular 
cantidad de letras que tiene.
*******************************************************************************/
using System;

class Calculadora 
{
     static void Main(){
         
    Console.Write("Ingrese una frase: ");
    string frase = Console.ReadLine();
    Console.WriteLine("Su frase tiene: " + frase.Length + " letras");
  }
}