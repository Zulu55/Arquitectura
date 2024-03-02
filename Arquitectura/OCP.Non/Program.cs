using OCP.Non;

class Program
{
    static void Main(string[] args)
    {
        var empleado1 = new EmpleadoHora(160, 10, "Arnulfo");
        var empleado2 = new EmpleadoFijo(30000, "Magola");

        var empleados = new List<object> { empleado1, empleado2 };

        var contador = new Contador(empleados);
        contador.CalcularNomina();
    }
}