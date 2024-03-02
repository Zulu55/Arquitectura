namespace OCP.Non
{
    public class EmpleadoFijo
    {
        public decimal Salario { get; set; }
        public string Nombre { get; set; }

        public EmpleadoFijo(decimal salario, string nombre)
        {
            Salario = salario;
            Nombre = nombre;
        }
    }
}