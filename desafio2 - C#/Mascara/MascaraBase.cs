using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Mascara
{
    public abstract class MascaraBase
    {
        protected string AplicarMascara(string valor,string mascara)
        {
        	if (string.IsNullOrEmpty(valor)) { throw new ArgumentNullException(nameof(valor)); }
            if (string.IsNullOrEmpty(mascara)) { throw new ArgumentNullException(nameof(mascara)); }
            
            StringBuilder sb = new StringBuilder();

            int idx = 0;
            for (int i = 0; i < mascara.Length; i++)
            {
                var c = mascara[i];
                if (c == '#')
                {
                    sb.Append(valor[idx]);
                    idx++;
                }
                else
                {
                    sb.Append(c);
                }
            }

            var formatado = sb.ToString();
            return formatado;
        }
    }
}
