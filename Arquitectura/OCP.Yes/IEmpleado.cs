namespace OCP.Yes
{
    public interface IEmpleado
    {
        string Nombre { get; }

        decimal CalcularSalarioAnual();
    }
}