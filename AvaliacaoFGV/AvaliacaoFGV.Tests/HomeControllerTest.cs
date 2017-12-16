using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Dados.Tests
{
    [TestClass()]
    public class HomeControllerTest
    {
        [TestMethod()]
        public void OrdenarTestTituloAsc()
        {
            //Arrange
            dadosOrdenaLivros ordenar = new dadosOrdenaLivros();

            var lstLivros = ordenar.criarLista();

            List<Parametro> tituloAscParam = new List<Parametro>();

            tituloAscParam.Add(new Parametro() {
                campoOrdenacao = "titulo",
                tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.asc
            });

            //Act
            var resultado = ordenar.Ordenar(tituloAscParam);
            string retorno = "";

            //Assert
            foreach(Livro l in resultado)
            {
                retorno = retorno + l.Id;
            }

            Assert.AreEqual(retorno, "3412");
        }

        [TestMethod()]
        public void OrdenarTestAutorAscTituloDesc()
        {
            //Arrange
            dadosOrdenaLivros ordenar = new dadosOrdenaLivros();

            var lstLivros = ordenar.criarLista();

            List<Parametro> tituloAscParam = new List<Parametro>();

            tituloAscParam.Add(
                new Parametro()
                {
                    campoOrdenacao = "autorNome",
                    tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.asc
                }
            );

            tituloAscParam.Add(
                new Parametro()
                {
                    campoOrdenacao = "titulo",
                    tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.desc
                }
            );

            //Act
            var resultado = ordenar.Ordenar(tituloAscParam);
            string retorno = "";

            //Assert
            foreach (Livro l in resultado)
            {
                retorno = retorno + l.Id;
            }

            Assert.AreEqual(retorno, "1432");
        }

        [TestMethod()]
        public void OrdenarTestEdicaoDescAutorDescTituloAsc()
        {
            //Arrange
            dadosOrdenaLivros ordenar = new dadosOrdenaLivros();

            var lstLivros = ordenar.criarLista();

            List<Parametro> tituloAscParam = new List<Parametro>();

            tituloAscParam.Add(
                new Parametro()
                {
                    campoOrdenacao = "edicaoAno",
                    tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.desc
                }
            );

            tituloAscParam.Add(
                new Parametro()
                {
                    campoOrdenacao = "autorNome",
                    tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.desc
                }
            );

            tituloAscParam.Add(
                new Parametro()
                {
                    campoOrdenacao = "titulo",
                    tipoOrdenacao = EnumOrdenacao.tipoOrdenacao.asc
                }
            );

            //Act
            var resultado = ordenar.Ordenar(tituloAscParam);
            string retorno = "";

            //Assert
            foreach (Livro l in resultado)
            {
                retorno = retorno + l.Id;
            }

            Assert.AreEqual(retorno, "4132");
        }

        [TestMethod()]
        public void OrdenarTestNulo()
        {
            //Arrange
            dadosOrdenaLivros ordenar = new dadosOrdenaLivros();

            var lstLivros = ordenar.criarLista();

            List<Parametro> tituloAscParam = new List<Parametro>();

            //Act
            string retorno = "";
            var resultado = (tituloAscParam == null ? null : ordenar.Ordenar(tituloAscParam));

            //Assert
            if (resultado != null)
            {
                foreach (Livro l in resultado)
                {
                    retorno = retorno + l.Id;
                }

                Assert.AreEqual(retorno, "3412");
            }
            else
            {
                Assert.Fail("O teste falhou.");
            }
        }
    }
}