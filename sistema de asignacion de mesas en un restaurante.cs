using System.Text.Json.Nodes;

namespace proyecto2_restaurante
{
    // Clase que guarda los datos básicos de cada cliente o grupo que llega al restaurante
    public class cliente
    {
        public string nombre { get; set; }   // Nombre de quien reserva o pide la mesa
        public int Personas { get; set; }    // Cuántas personas vienen en el grupo

        // Constructor para crear el cliente con su nombre y cantidad de personas
        public cliente(string nombre, int cantidadPersonas)
        {
            // Ojo aquí: falta 'this.nombre = nombre;' y 'Personas = cantidadPersonas;' para que no queden vacíos
            nombre = nombre;
            Personas = Personas;
        }

        // Sobrescribimos ToString para que al imprimir el objeto salga bonito en consola
        public override string ToString()
        {
            return $"{nombre} - {Personas}personas";
        }
    }
}             




        
    










