using System;
using System.Linq;

namespace examendbtglobal
{
    class Program
    {

        public static void Main(string[] args)
        {
            try {

                Console.WriteLine("Bienvenidos examen dbtglobal");

                Console.WriteLine("Ingrese el numero  al temario del examen 1:Ocurrecnias,2:Lista Asteriscos ");
                int Respuesta = int.Parse(Console.ReadLine());
                var examen = new Examen(); 
                Console.WriteLine("ingrese los numeros separados por coma");
                
                var array = examen.ConvertirArray(Console.ReadLine().ToString());

                if (Respuesta == 1)
                {
                    Console.WriteLine("Ingrese el numero  al que decea buscar en el array");
                    int numerobuscador = int.Parse(Console.ReadLine());
                    Console.WriteLine("El numero que ingreso coincide:" + examen.Ocurrecnias(numerobuscador, array) + " veces");
                }
                if (Respuesta == 2)
                {
                    //int[] myArray = { 8, 1, 6, 7, 8, 4, 9, 8, 2 };este era el ejemplo en word

                    var validarango = array.GroupBy(x => x).Where(g => g.Key > 9).Count();

                    if (validarango != 0)
                    {
                        Console.WriteLine("Elementos fuera de Rangos 1-9");
                    }
                    else
                    {
                        examen.tema2(array);
                    }
                }

            } catch (Exception ex) {

                Console.WriteLine("Error inesperado", ex.Message);
                Console.WriteLine("Compruebe que los datos sean correctos");
            }
            
        }
    }
}
