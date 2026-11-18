using System.Text.Json.Nodes;

namespace proyecto6_tareas
{
    // Clase modelo que representa cada tarea dentro de la lista
    public class tarea
    {
        public int id { get; set; }             // Número identificador único de la tarea
        public string descripcion { get; set; } // Texto de lo que hay que hacer
        public string estado { get; set; }      // Estado actual (por ejemplo: pendiente o completada)

        // Constructor que recibe el id y la descripción, y la marca como pendiente por defecto
        public tarea(int id, string descripcion)
        {
            // Ojo aquí: falta 'this.id = id;' y 'this.descripcion = descripcion;' para que no se asignen a sí mismos
            id = id;
            descripcion = descripcion;
            estado = "pendiente";
        }

        // Sobrescribimos ToString para imprimir la tarea ya formateada en consola
        public override string ToString()
        {
            return $"{id}-{descripcion}-{estado}";
        }
    }
}
