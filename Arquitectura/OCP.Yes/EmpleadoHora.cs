namespace OCP.Yes
{
    public class EmpleadoHora : IEmpleado
    {
        public int HorasMes { get; set; }
        public decimal ValorHora { get; set; }
        public string Nombre { get; set; }

        public EmpleadoHora(int horasMes, decimal valorHora, string nombre)
        {
            HorasMes = horasMes;
            ValorHora = valorHora;
            Nombre = nombre;
        }

        public decimal CalcularSalarioAnual()
        {
            return HorasMes * ValorHora * 12;
        }
    }
}