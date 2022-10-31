using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal static class ExtensionesString
    {
        internal static int ContarPalabras(this string? s) 
        {
            if (string.IsNullOrWhiteSpace(s)) 
            {
                return -1;
            }

            //Felipe
            //Gavilan
            var separadores = new string[] {" ", Environment.NewLine};
            var palabras = s.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length;
        }

    }
}
