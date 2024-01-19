using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nodo
    {
        public int  valor { get; set; }
       public Nodo siguiente { get; set; }

        public Nodo anterior { get; set; }

        public Nodo(int x) {
        
        valor = x;
        siguiente = null;
        anterior = null;


        }


    public void AgregarNodo_Siguiente(Nodo Nodo_Siguiente) {
        
        
       siguiente= Nodo_Siguiente;
        
        
        
        }

        public void AgregarNodo_Anterior(Nodo Nodo_anterior) {
        this.anterior = Nodo_anterior;
        
        }

        public int ActualizarValor(int nuevoValor) {
        this.valor = nuevoValor;
        return this.valor;
        
        }

    }
}
