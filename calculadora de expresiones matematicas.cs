namespace proyecto4_calculadora
{
    // Clase para manejar la estructura de datos Pila (LIFO: el último que entra es el primero que sale)
    public class pila
    {
        // Apuntador al elemento que está hasta arriba de la pila
        private nodo cima;

        // Clase interna para crear cada "cajita" o nodo de la pila
        private class nodo
        {
            public char dato;          // Guarda el operador o paréntesis
            public nodo siguiente;     // Apunta al nodo que quedó abajo

            // Constructor para inicializar el nodo con su dato
            public nodo(char dato)
            {
                this.dato = dato;
            }
        }

        // Revisa si la pila no tiene nada
        public bool vacia()
        {
            return cima == null;
        }

        // Mete un nuevo dato hasta arriba de la pila (Push)
        public void apilar(char dato)
        {
            nodo nuevo = new nodo(dato); // Creamos el nodo
            nuevo.siguiente = cima;      // Lo enlazamos con el que estaba antes
            cima = nuevo;                // Ahora este nuevo es el de hasta arriba
        }

        // Saca y borra el dato de hasta arriba (Pop)
        public char desapilar()
        {
            if (vacia())
                return '\0'; // Si está vacía regresamos carácter nulo para que no truene

            char dato = cima.dato; // Rescatamos el valor antes de borrarlo
            cima = cima.siguiente; // Recorremos la cima al de abajo

            return dato;
        }

        // Solo nos deja ver qué hay hasta arriba sin sacarlo (Peek)
        public char tope()
        {
            if (vacia())
                return '\0';

            return cima.dato;
        }
    }
}











