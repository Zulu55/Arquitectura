namespace OCP.Yes
{
    public class Contador
    {
        private List<IEmpleado> _empleados;

        public Contador(List<IEmpleado> empleados)
        {
            _empleados = empleados;
        }

        public void CalcularNomina()
        {
            foreach (var empleado in _empleados)
            {
                var sueldoEmp = empleado.CalcularSalarioAnual();
                Console.WriteLine($"{empleado.Nombre} - {sueldoEmp}");
            }
        }
    }
}