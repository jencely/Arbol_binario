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
      
        [TestMethod]
        public void ContarHojas()
        {
            Nodo nodo1 = new Nodo("1");
            Nodo nodo2 = new Nodo("2");
            Nodo nodo3 = new Nodo("3");
            Nodo nodo4 = new Nodo("4");
            Nodo nodo5 = new Nodo("5");
            Nodo nodo6 = new Nodo("6");
            

            //Raiz
            nodo1.Hijos.Add(nodo2);
            nodo1.Hijos.Add(nodo3);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            int resultadoEsperado = 8;
            int resultado = NodoExt.ContarHojas(nodoA);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ContarNiveles()
        {
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo1 = new Nodo("1");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            NodoExt nodoN = new NodoExt("N");
            NodoExt nodoX = new NodoExt("X");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(nodoN);
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            nodoN.Hijos.Add(nodoX);

            int resultadoEsperado = 5;
            int resultado = NodoExt.ContarNiveles(nodoA);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
