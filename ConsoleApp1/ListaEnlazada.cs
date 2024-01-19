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
        protected Nodo cola  { get; set; }


        public ListaEnlazada(Nodo primerNodo) {

            Cabeza = primerNodo;
            cola = primerNodo;
        }

        public void InsertarNodoAlfinal(Nodo nuevo_nodo) {
            cola.siguiente = nuevo_nodo;
            cola = cola.siguiente;
        }

        public void borrarNodo(Nodo nodo) {

            nodo.siguiente = null;
        
        }

        public Nodo Buscar_nodo(int valor_A_buscar) {
            Nodo Nodo_Actual = Cabeza;
        while (Nodo_Actual != null) {
                if (Nodo_Actual.valor == valor_A_buscar)
                {


                    return Nodo_Actual;

                }
                else {
                    Nodo_Actual = Nodo_Actual.siguiente;
                }
            
            
            
            
            }

            return null;
        }


        public void BorrarNodoPorValor(int Valor_A_Borra) {

            Nodo NodoABorrar = Buscar_nodo(Valor_A_Borra);
            if (NodoABorrar != null)
            {
                borrarNodo(NodoABorrar);
            }

           
        
        
        }
    }
}
