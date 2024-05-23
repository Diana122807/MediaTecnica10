/******************************************************************************
Autora: Diana Carolina
Fecha: 22-05-24
descripcion: Un docente requiere de un sistema de notas
donde recibe 4 calificaciones generando un promedio
y luego determinando si gana o pierde.
Si su promedio es menor a 3 pierde
Si es mayor gana
Si tiene un promedio mayor a 4.5 emitir mensaje:
"Felicidades, te has ganado una beca"
*******************************************************************************/
using System;
class Programa
{
  static void Main() 
 { 
     double nota1, nota2, nota3, nota4;
     
      Console.WriteLine("Ingresa nota 1: ");
      nota1 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("Ingresa nota 2: ");
      nota2 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("Ingresa nota 3: ");
      nota3 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("Ingresa nota 4: ");
      nota4 = Convert.ToDouble(Console.ReadLine());
      
      double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
      
      
    
      
      if (promedio <= 3.5){
           Console.WriteLine("perdiste");
           
       }
       if (promedio <=3.0 ){
           Console.WriteLine("perdiste");
       
       }  
     if (promedio >= 4.5){
         Console.WriteLine("Felicidades ganaste una beca");
        }
        
        if (promedio <= 4.4){
         Console.WriteLine("ganaste");
        }

      
  }
}