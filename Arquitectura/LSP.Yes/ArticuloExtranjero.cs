namespace LSP.Yes
{
    public class ArticuloExtranjero : Articulo, IImportable
    {
        public double Impuesto { get; set; }

        public ArticuloExtranjero(string nombre, double precio, double impuesto = 0.15) : base(nombre, precio)
        {
            Impuesto = impuesto;
        }

        public override double ObtenerPrecio()
        {
            return Precio * (1 + Impuesto);
        }

        public void Importar()
        {
            Console.WriteLine("Importando artículo extranjero...");
        }
    }
}