using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class dadosOrdenaLivros : IOrdenaLivros<Livro>
    {
        public List<Livro> criarLista()
        {
            //Criando a lista de livros - Inicio
            List<Livro> lstLivro = new List<Livro>();

            var livro1 = new Livro()
            {
                Id = 1,
                titulo = "Java How to Program",
                autorNome = "Deitel & Deitel",
                edicaoAno = 2007

            };

            lstLivro.Add(livro1);

            var livro2 = new Livro()
            {
                Id = 2,
                titulo = "Patterns of Enterprise Application Architecture",
                autorNome = "Martin Fowler",
                edicaoAno = 2002

            };

            lstLivro.Add(livro2);

            var livro3 = new Livro()
            {
                Id = 3,
                titulo = "Head First Design Patterns",
                autorNome = "Elisabeth Freeman",
                edicaoAno = 2004

            };

            lstLivro.Add(livro3);

            var livro4 = new Livro()
            {
                Id = 4,
                titulo = "Internet & World Wide Web: How to Program",
                autorNome = "Deitel & Deitel",
                edicaoAno = 2007

            };

            lstLivro.Add(livro4);
            //Criando a lista de livros - Fim

            return lstLivro;
        }

        public List<Livro> Ordenar(List<Parametro> parametros)
        {
            var lstLivro = criarLista();

            //Fazendo a ordenação de acordo com a lista de parametros enviada
            foreach (Parametro p in parametros)
            {
                switch(p.campoOrdenacao)
                {
                    case "titulo":
                    
                        if (p.tipoOrdenacao == EnumOrdenacao.tipoOrdenacao.asc)
                            lstLivro = lstLivro.OrderBy(l => l.titulo).ToList();
                        else
                            lstLivro = lstLivro.OrderByDescending(l => l.titulo).ToList();
                        break;
                    case "autorNome":

                        if (p.tipoOrdenacao == EnumOrdenacao.tipoOrdenacao.asc)
                            lstLivro = lstLivro.OrderBy(l => l.autorNome).ToList();
                        else
                            lstLivro = lstLivro.OrderByDescending(l => l.autorNome).ToList();
                        break;
                    case "edicaoAno":

                        if (p.tipoOrdenacao == EnumOrdenacao.tipoOrdenacao.asc)
                            lstLivro = lstLivro.OrderBy(l => l.edicaoAno).ToList();
                        else
                            lstLivro = lstLivro.OrderByDescending(l => l.edicaoAno).ToList();
                        break;
                    default:
                        if (p.tipoOrdenacao == EnumOrdenacao.tipoOrdenacao.asc)
                            lstLivro = lstLivro.OrderBy(l => l.titulo).ToList();
                        else
                            lstLivro = lstLivro.OrderByDescending(l => l.titulo).ToList();
                        break;
                }    
            }

            return lstLivro;
        }
    }
}
