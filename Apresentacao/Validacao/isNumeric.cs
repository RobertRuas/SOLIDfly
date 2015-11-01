using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Validacao
{
    class isNumeric
    {
        public bool Verificar(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }
    }
}
