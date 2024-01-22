using ConsoleApp1;

ListaEnlazada listaEnlazada = new ListaEnlazada(new Nodo(1));

listaEnlazada.InsertarNodoAlfinal(new Nodo(2));
listaEnlazada.InsertarNodoAlfinal(new Nodo(3));
listaEnlazada.InsertarNodoAlfinal(new Nodo(4));


Console.WriteLine("Lista Original:");
listaEnlazada.MostrarLista();

listaEnlazada.OddEvent_LinkedList();

Console.WriteLine("Lista Reorganizada:");
listaEnlazada.MostrarLista();