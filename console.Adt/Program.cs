using Adt;
using System;

namespace Arbol.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbol binario");
            string valor = Console.ReadLine();
            var raiz = new Nodo(
                "*",
                new Nodo("0", new Nodo("00")),
                new Nodo("1", new Nodo("10")));
            raiz.Nombre = "1";

            var nodo1 = new Nodo(valor);
            nodo1.Nombre = "1.1";

            var nodo2 = new Nodo();
            nodo2.Nombre = "1.2";
            var nodo3 = new Nodo();
            nodo3.Nombre = "1.3";

            raiz.Izquierdo = nodo1;
            raiz.Derecho = nodo2;
            //metodo imprimir recursivo
            Administrador admin = new Adt.Administrador();
            //an.Imprimir(raiz);

            //5 + 6 - 2 - 1
            var Arbol_operaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("-",
                    new Nodo("6"),
                    new Nodo("-",
                        new Nodo("2"),
                        new Nodo("1"))));
            //caracteres validos [0-9] numeros, . searador decimal
            // +- opreadores, para el nombre prop
            Console.WriteLine("La suma del arbol es: " + admin.Operacion_expresion(Arbol_operaciones));
            Console.WriteLine("\n");

            Nodo nodo_Operacion = new Nodo();
            admin.Crear_arbol(nodo_Operacion, "5+6+2+1");
            admin.Recorrer_Arbol(nodo_Operacion);
           


        }

    }
}


