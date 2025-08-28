using System;

namespace Semana6
{
    public class Estudiante
    {
        public string cedula, nombre, apellido, correo;
        public float nota;
        public Estudiante? siguiente;

        public Estudiante(string c, string n, string a, string e, float notaFinal)
        {
            cedula = c;
            nombre = n;
            apellido = a;
            correo = e;
            nota = notaFinal;
            siguiente = null;
        }
    }

    public class ListaEstudiantes
    {
        private Estudiante? inicio;

        public void Agregar(Estudiante nuevo)
        {
            if (nuevo.nota >= 7)
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
            else
            {
                if (inicio == null)
                    inicio = nuevo;
                else
                {
                    Estudiante actual = inicio;
                    while (actual.siguiente != null)
                        actual = actual.siguiente;
                    actual.siguiente = nuevo;
                }
            }
        }

        public Estudiante? BuscarPorCedula(string cedula)
        {
            Estudiante? actual = inicio;
            while (actual != null)
            {
                if (actual.cedula == cedula)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public void Eliminar(string cedula)
        {
            if (inicio == null) return;

            if (inicio.cedula == cedula)
            {
                inicio = inicio.siguiente;
                return;
            }

            Estudiante actual = inicio;
            while (actual.siguiente != null && actual.siguiente.cedula != cedula)
                actual = actual.siguiente;

            if (actual.siguiente != null)
                actual.siguiente = actual.siguiente.siguiente;
        }

        public void Contar(out int aprobados, out int reprobados)
        {
            aprobados = reprobados = 0;
            Estudiante? actual = inicio;
            while (actual != null)
            {
                if (actual.nota >= 7) aprobados++;
                else reprobados++;
                actual = actual.siguiente;
            }
        }

        public void Mostrar()
        {
            Estudiante? actual = inicio;
            while (actual != null)
            {
                Console.WriteLine($"{actual.nombre} ({actual.cedula}) - Nota: {actual.nota}");
                actual = actual.siguiente;
            }
        }
    }
}
