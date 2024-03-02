namespace OCP.Non
{
    public class Contador
    {
        private readonly List<object> _empleados;

        public Contador(List<object> empleados)
        {
            _empleados = empleados;
        }

        public void CalcularNomina()
        {
            foreach (var emp in _empleados)
            {
                if (emp is EmpleadoHora)
                {
                    var empleado = emp as EmpleadoHora;
                    var sueldoEmp = empleado!.HorasMes * empleado.ValorHora * 12;
                    Console.WriteLine($"{empleado.Nombre} - {sueldoEmp}");
                }
                else if (emp is EmpleadoFijo)
                {
                    var empleado = emp as EmpleadoFijo;
                    var sueldoEmp = empleado!.Salario * 12;
                    Console.WriteLine($"{empleado.Nombre} - {sueldoEmp}");
                }
            }
        }
    }
}