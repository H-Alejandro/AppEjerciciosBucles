using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjerciciosBucles.Funciones
{
    public static class EjemplosBucles
    {
        public static string saludar(int limite)
        {
            StringBuilder cad = new StringBuilder("Saludos\n");
                int i = 0;
            while (i<limite)
            {
                i++;
                cad.Append(i.ToString() + ":Hola\n" + Environment.NewLine);

            }
            return cad.ToString();

        }
        

    }
}
