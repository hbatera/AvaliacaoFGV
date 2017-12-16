using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal interface IOrdenaLivros<T>
    {
        List<T> Ordenar(List<Parametro> Livros);
    }
}
