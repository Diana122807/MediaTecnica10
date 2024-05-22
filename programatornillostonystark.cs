/******************************************************************************
Autora: Diana Carolina
Fecha: 22-05-24
descrpcion: Tony stark, iron man, quiere saber cuanto
dinero debe tener para comprar X tornillos c/u a $300, pero en la tienda
le dan descuentos segun cantidad comprada.
Crear un algoritmo que ayude a calcular si compra:
1 sin descuento
5 con descuento de 30%
10 con descuento de 50%
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      int cantidadTornillos;
      int valorTornillos;
      
      Console.WriteLine("Digite la cantidad de tornillos: ");
      cantidadTornillos = Int32.Parse(Console.ReadLine());
      
      Console.WriteLine("Digite el valor de los tornillos: ");
       valorTornillos = Int32.Parse(Console.ReadLine());
       
       if (cantidadTornillos == 1){
           Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.0));
           cantidadTornillos = Int32.Parse(Console.ReadLine());
       }
       if (cantidadTornillos > 5){
        
        Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.30));
        cantidadTornillos = Int32.Parse(Console.ReadLine());
       }  
     if (cantidadTornillos > 10){
         Console.WriteLine("la catidad de tornilos");
        Console.WriteLine("el valor de los tornillos es: " + (valorTornillos * 0.50));
        }
  }  
     }
    