using System;

class Program 
{
    public static void Main (string[] args) 
    {
      /*10. Leer dos números enteros y si la diferencia entre los dos 
      es menor o igual a 10 entonces mostrar en pantalla todos los enteros 
      comprendidos entre el menor y el mayor de los números leídos */

      Console.WriteLine("Ingrese el primer numero entero: ");
      int n1;

      try
      {
        n1 = Convert.ToInt32(Console.ReadLine());
      }
      catch (FormatException)
      {
        Console.WriteLine("El número ingresado no es un número entero válido");
        return; // El programa detectara si es un string 
      }

      Console.WriteLine("Ingrese el segundo numero entero: ");
      int n2;

      try
      {
        n2 = Convert.ToInt32(Console.ReadLine());
      }
      catch (FormatException)
      {
        Console.WriteLine("El número ingresado no es un número entero válido");
        return; // El programa detectara si es un string 
      }

      int dif = Math.Abs(n1 - n2);
      
      if (dif <= 10)
      {
          int menor = Math.Min(n1, n2);
          int mayor = Math.Max(n1, n2);
        
          Console.WriteLine("Los numeros comprendidos entre " + n1 + " y " + n2 + " son: ");
          for (int x = menor; x <= mayor; x++)
          {
              Console.WriteLine(x);
          }
      }
      else
      {
          Console.WriteLine("La diferencia entre los números es mayor a 10");
      }
    }
}
