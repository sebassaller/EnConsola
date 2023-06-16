using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examendbtglobal
{
    public class Examen
    {
        public  int[] ConvertirArray(string foo)
        {
            string[] tokens = foo.Split(",");
            List<int> nums = new List<int>();
            int oneNum;
            foreach (string s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }
            return nums.ToArray();
        }


        public int Ocurrecnias(int buscador, int[] array)
        {
            int contador = 0;
            foreach (int i in array)
            {
                if (i == buscador)
                {
                    contador++;
                }
            }
            return contador;
        }
        public void tema2(int[] array)
        {

            Array.Sort(array);
            var ListaArray = array.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => new { item = y.Key, count = y.Count() }).ToList();
            for (int ii = 0; ii < 10; ii++)
            {
                var validar = ListaArray.GroupBy(x => x).Where(g => g.Key.item == ii).Any();

                if (validar==false)
                {
                    ListaArray.Insert(ii, new { item = ii, count = 0 });
                }
                if (ListaArray[ii].item > 0)
                {
                    Console.WriteLine(ListaArray[ii].item + ":" + Asteriscos(ListaArray[ii].count));
                }
            }
        }
       public static string Asteriscos(int Entero)
        {
            string resul = "";
            if (Entero > 0)
            {
                for (int n = 1; n <= Entero; n++)
                {
                    resul = resul + "*";
                }
            }
            return resul;
        }
    }
}
