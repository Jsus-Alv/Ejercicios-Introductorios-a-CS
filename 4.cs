using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /*4. Leer dos números enteros de dos dígitos y 
    determinar si la suma de los dos números origina un número par. */

    Console.WriteLine("Ingrese el primer numero entero de dos dígitos: ");
    int n1;

    try
    {
      n1 = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("El valor ingresado no es un número entero válido");
      return; // El programa detectara si es un string 
    }

    Console.WriteLine("Ingrese el segundo numero entero de dos dígitos: ");
    int n2;

    try
    {
      n2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("El valor ingresado no es un número entero válido");
      return; // El programa detectara si es un string 
    }

    if (((n1 >= -99 && n1 <= -10) || (n1 >= 10 && n1 <= 99)) && ((n2 >= -99 && n2 <= -10) || (n2 >= 10 && n2 <= 99)))
    {
      int sum = (n1 + n2);

      if (sum % 2 == 0)
      {
        Console.WriteLine("La suma de los dos números es " + sum + " y es par");
      }
      else 
      {
        Console.WriteLine("La suma de los dos números es " + sum + " y no es par");
      }    
    }
    else 
    {
      Console.WriteLine("Al menos uno de los numeros ingresados no es de dos dígitos");
    }
  }
}
