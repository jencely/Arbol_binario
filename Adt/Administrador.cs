using System;
using System.Collections.Generic;
using System.Text;

namespace Adt
{
    public class Administrador
    {
       public  double Calcular(string expresionMatematica)
        {
            var raiz = new Nodo();
            Crear_arbol(raiz, expresionMatematica);

            return Evaluar(raiz);



        }

        private double Evaluar(Nodo nodo)
        {
            //toda funcion recursiva debe pensar en 3 cosas
            //1. Que debo hacer cuando el nodo actual es la raiz


            //2. Que debo hacer cuando el nodo actual es una hoja
            if (Es_numero(nodo.Nombre))
            {
                return ConvertirEnNumero(nodo.Nombre);
            }
            //3. que devbo hacer cuando el nodo actual no es nodo ni raiz

            var izquierdo = Evaluar(nodo.Izquierdo);
            var derecho = Evaluar(nodo.Derecho);

            if (nodo.Nombre == "+")
            {
                return izquierdo + derecho;
            }
            else
            {
                throw new ArgumentException("Operación Invalida!");
            }
        }

        private double ConvertirEnNumero(string valor)
        {
            return double.Parse(valor);
        }

        private bool Es_numero(string valor)
        {
            throw new NotImplementedException();
        }

        public void Crear_arbol(Nodo nodo, string expresionMatematica)
        {
            var indice_operador = buscar_operador(expresionMatematica);
            var operando_izquierdo = expresionMatematica.Substring(0, indice_operador);

            nodo.Nombre = expresionMatematica.Substring(indice_operador, 0);
            nodo.Izquierdo = new Nodo(operando_izquierdo);

            nodo.Derecho = new Nodo();
            Crear_arbol(nodo.Derecho, expresionMatematica.Substring(indice_operador));
        }
    public void Recorrer_Arbol(Nodo Nodo)
    {
        if (Nodo == null) return;

        Console.WriteLine(Nodo.Nombre);
        Recorrer_Arbol(Nodo.Izquierdo);
        Recorrer_Arbol(Nodo.Derecho);
    }

    private int buscar_operador(string expresionMatematica)
        {
            var indice_mas = expresionMatematica.IndexOf('+');
            var indice_menos = expresionMatematica.IndexOf('-');

            return indice_mas < indice_menos ? indice_mas : indice_menos;
        }
        //metodo para la suma de la expresion dada
    public int Operacion_expresion(Nodo nodo)
        {
            if (Es_numero(nodo.Nombre) || nodo == null)
            {
                int izquierdo = Operacion_expresion(nodo.Derecho);
                int derecho = Operacion_expresion(nodo.Izquierdo);
                return (izquierdo + derecho);
            }
            else
            {
                return ((int)ConvertirEnNumero(nodo.Nombre));
            }
        }

        //metodo cantidad de nodos
        private readonly Nodo raiz;
        private int cantidad;
        private void Cantidad_nodos(Nodo recorrido)
        {
            if (recorrido != null)
            {

                cantidad++;
                Cantidad_nodos(recorrido.Izquierdo);
                Cantidad_nodos(recorrido.Derecho);
            }
        }

        public int Cantidad(Nodo izquierdo)
        {
            cantidad = 0;
            Cantidad(raiz);
            return cantidad;
        }
        //metodo contar las hojas del nodo
        private void Contar_Hoja(Nodo recorrido)
        {
            if (recorrido != null)
            {
                if (recorrido.Izquierdo == null && recorrido.Derecho == null)
                    cantidad++;
                Contar_Hoja(recorrido.Izquierdo);
                Contar_Hoja(recorrido.Derecho);
            }
        }

        public int Contar_Hoja()
        {
            cantidad = 0;
            Contar_Hoja(raiz);
            return cantidad;
        }
        //metodo contar los niveles
        private void Nivel(Nodo recorrido, int nivel)
        {
            if (recorrido != null)
            {
                Nivel(recorrido.Izquierdo, nivel + 1);
                Console.Write(recorrido.Nombre + " (" + nivel + ") - ");
                Nivel(recorrido.Derecho, nivel + 1);
            }
        }

        public void Nivel()
        {
            Nivel(raiz, 1);
            Console.WriteLine();
        }
    }
}
