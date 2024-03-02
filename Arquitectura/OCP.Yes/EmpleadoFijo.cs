namespace OCP.Yes
{
    public class EmpleadoFijo : IEmpleado
    {
        public decimal Salario { get; set; }
        public string Nombre { get; set; }

        public EmpleadoFijo(decimal salario, string nombre)
        {
            Salario = salario;
            Nombre = nombre;
        }

        public decimal CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }
}