using ConsoleApp1;
Nodo nodo = new Nodo(2);

ListaEnlazada listaEnlazada = new ListaEnlazada(new Nodo(1));

listaEnlazada.InsertarNodoAlfinal(nodo);
listaEnlazada.InsertarNodoAlfinal(new Nodo(3));
listaEnlazada.InsertarNodoAlfinal(new Nodo(4));
listaEnlazada.InsertarNodoAlfinal(nodo);


Console.WriteLine(listaEnlazada.Linked_List_Cyrcle());