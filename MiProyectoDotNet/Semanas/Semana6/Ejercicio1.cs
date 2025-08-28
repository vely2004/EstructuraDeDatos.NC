using System;

namespace Semana6
{
    // Clase Nodo
    public class Nodo
    {
        public int valor;
        public Nodo? siguiente;

        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }
    }

    // Clase Lista con método para invertir
    public class ListaInvertida
    {
        private Nodo? cabeza;

        // Agregar un nuevo nodo al inicio
        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.siguiente = cabeza;
            cabeza = nuevo;
        }

        // Método para invertir la lista enlazada
        public void Invertir()
        {
            Nodo? anterior = null;
            Nodo? actual = cabeza;
            Nodo? siguiente;

            while (actual != null)
            {
                siguiente = actual.siguiente;
                actual.siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        // Mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo? actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.valor + " ");
                actual = actual.siguiente;
            }
            Console.WriteLine("null");
        }
    }
}
