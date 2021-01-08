using Adt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArbolBinario.Test
{
    [TestClass]
    public class ArbolBinarioTest
    {
        [TestMethod]
        public void Calcular_Arbol_Operaciones()
        {
            var expresionMatematica = "5+6-2-1";
            var esperando = 8;

            var calculadora_arbol = new Administrador();
            var resultado = calculadora_arbol.Calcular(expresionMatematica);

            Assert.AreEqual(esperando, resultado);
        }
        [TestMethod]
        public void Contar_nodos()
        {
            Nodo nodo = new Nodo();
            int resultadoEsperado = 1;
            int resultado = Nodo.Cantidad_nodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
      
        
    }
}
