using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Mascara
{
    public class MascaraCPF: MascaraBase
    {
        public string Aplicar(string textoCPF)
        {
            String modificada;
            var mascarado = "";


            char[] arrayDeChar = textoCPF.ToCharArray();
            for (int i = 0; i < textoCPF.Length; i++)
            {
                if (Char.IsDigit(arrayDeChar[i]))
                {
                    arrayDeChar[i] = '#';
                }
            }

            string astr = new string(arrayDeChar);
            

            if (astr.Length > 3 && astr.Length <= 6)
            {
                modificada = astr.Insert(3, ".");
                mascarado = AplicarMascara(textoCPF, modificada);
                
            }
            else if (astr.Length > 6 && astr.Length <= 9)
            {
                modificada = astr.Insert(3, ".");
                String modificada1 = modificada.Insert(7, ".");
                Console.WriteLine("Modificada: " + modificada1);
                mascarado = AplicarMascara(textoCPF, modificada1);
                
            }
            else if (astr.Length > 9 && astr.Length <= 10)
            {
                mascarado = AplicarMascara(textoCPF, "###.###.###-#");
            }
            else if (astr.Length > 10)
            {
                mascarado = AplicarMascara(textoCPF, "###.###.###-##");
            }
            else
            {
                mascarado = AplicarMascara(textoCPF, astr);
            }

            return mascarado;


        } 
    }
}
