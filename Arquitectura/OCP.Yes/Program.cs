using OCP.Yes;

class Program
{
    static void Main(string[] args)
    {
        var empleados = new List<IEmpleado>
        {
            new EmpleadoHora(160, 10, "Arnulfo"),
            new EmpleadoFijo(30000, "Magola")
        };

        var contador = new Contador(empleados);
        contador.CalcularNomina();
    }
}