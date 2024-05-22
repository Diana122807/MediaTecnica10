/******************************************************************************
Autora: Diana Carolina
Fecha: 22-05-24
descrpcion: Programa con decisiones para habilitar votacion de 
personas y descuento matricula de estudio.
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // variables
      int edad;
      int valorMatricula;
      
      // peticion de datos 
      Console.WriteLine("Digite su edad :");
      edad = Int32.Parse(Console.ReadLine());
      
      Console.WriteLine("Digite su valor de matricula: ");
      valorMatricula= Int32.Parse(Console.ReadLine());
      
      //validacion
      if( edad >= 18){
          Console.WriteLine("Felicidades, usted puede votar");
          Console.WriteLine("Uste pagara de matricula: " + (valorMatricula * 0.85));
       }
    }
 } 
