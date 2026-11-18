using proyecto1_clinica;
using proyecto1_Clinica;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto1_clinica
{
    // Clase modelo que guarda los datos básicos de cada paciente que llega a la clínica
    public class paciente
    {
        public int expediente { get; set; }  // Número de expediente clínico
        public string nombre { get; set; }   // Nombre completo del paciente
        public int edad { get; set; }        // Edad del paciente
        public int prioridad { get; set; }   // Nivel de urgencia con el que llega

        // Constructor para inicializar los datos del paciente al registrarlo
        public paciente(int expediente, string nombre, int edad, int prioridad)
        {
            // Ojo aquí: falta poner 'this.' antes de cada propiedad (ej. this.expediente = expediente;) para que no queden en 0 o null
            expediente = expediente;
            nombre = nombre;
            edad = edad;
            prioridad = prioridad;
        }

        // Sobrescribimos ToString para darle formato bonito cuando se imprima el paciente en consola
        public override string ToString()
        {
            return $"Expediente: {expediente}|" +
                $"Nombre:{nombre}|" +
                $"Edad:{edad}|" +
                $"Prioridad:{prioridad}";
        }
    }
}











                    




