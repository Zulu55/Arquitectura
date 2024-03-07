namespace LSP.Non
{
    public class ArticuloExtranjeroEspecial : Articulo
    {
        public ArticuloExtranjeroEspecial(string nombre, double precio, double impuesto = 0.05) : base(nombre, precio)
        {
            Impuesto = impuesto;
        }

        public override double ObtenerPrecio()
        {
            return Precio * (1 + Impuesto);
        }

        public override void Importar()
        {
            Console.WriteLine("Importando artículo extranjero especial...");
        }
    }
}