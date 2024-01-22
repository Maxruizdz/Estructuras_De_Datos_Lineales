using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class ListaEnlazada
    {
        protected Nodo Cabeza { get; set; }
        protected Nodo cola { get; set; }


        public ListaEnlazada(Nodo primerNodo)
        {

            Cabeza = primerNodo;
            cola = primerNodo;
        }

        public void InsertarNodoAlfinal(Nodo nuevo_nodo)
        {
            cola.siguiente = nuevo_nodo;
            cola = cola.siguiente;
        }

        public void borrarNodo(Nodo nodo)
        {

            nodo.siguiente = null;

        }

        public Nodo Buscar_nodo(int valor_A_buscar)
        {
            Nodo Nodo_Actual = Cabeza;
            while (Nodo_Actual != null)
            {
                if (Nodo_Actual.valor == valor_A_buscar)
                {


                    return Nodo_Actual;

                }
                else
                {
                    Nodo_Actual = Nodo_Actual.siguiente;
                }




            }

            return null;
        }


        public void BorrarNodoPorValor(int Valor_A_Borra)
        {

            Nodo NodoABorrar = Buscar_nodo(Valor_A_Borra);
            if (NodoABorrar != null)
            {
                borrarNodo(NodoABorrar);
            }




        }
        public void MostrarLista()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.valor + " ");
                actual = actual.siguiente;
            }
            Console.WriteLine();
        }

        public void RevertirListaEnlaza()
        {
            Nodo nodo_Anterio = null;

            Nodo nodoActual = Cabeza;

            while (nodoActual != null)
            {

                if (nodoActual.anterior != null)
                {

                    nodo_Anterio = nodoActual.anterior;
                    nodoActual.anterior = nodoActual.siguiente;
                    nodoActual.siguiente = nodo_Anterio;
                }

                nodoActual = nodoActual.siguiente;


            }


        }

        public void OddEvent_LinkedList()
        {

            Nodo nodo_cabeza = Cabeza;
            Nodo cabeza_impar = new Nodo(0);
            Nodo cabeza_par = new Nodo(0);
            Nodo primer_nodo_impar = cabeza_impar;
            Nodo primer_nodo_par = cabeza_par;

            while (nodo_cabeza != null)
            {
                if (nodo_cabeza.valor % 2 == 0)
                {
                    cabeza_par.siguiente = nodo_cabeza;
                    cabeza_par = cabeza_par.siguiente;
                }
                else
                {
                    cabeza_impar.siguiente = nodo_cabeza;
                    cabeza_impar = cabeza_impar.siguiente;
                }

                nodo_cabeza = nodo_cabeza.siguiente;
            }

            cabeza_par.siguiente = null;
            cabeza_impar.siguiente = primer_nodo_par.siguiente;
            Cabeza = primer_nodo_impar.siguiente;



        }


        public bool Linked_List_Cyrcle() {
            Nodo nodo_actual = Cabeza;
            Nodo nodo_siguiente = Cabeza.siguiente;

            while(nodo_actual is not null && nodo_siguiente is not null)
            {
                if (nodo_actual == nodo_siguiente) {
                    return true;
                
                }

                nodo_actual = nodo_actual.siguiente;
                nodo_siguiente = nodo_siguiente.siguiente.siguiente;



            }
            return false;



        }
    }


    }



    

