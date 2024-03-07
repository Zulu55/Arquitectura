namespace LSP.Non
{
    public class ArticuloExtranjero : Articulo
    {
        public ArticuloExtranjero(string nombre, double precio, double impuesto = 0.15) : base(nombre, precio)
        {
            Impuesto = impuesto;
        }

        public override double ObtenerPrecio()
        {
            return Precio * (1 + Impuesto);
        }

        public override void Importar()
        {
            Console.WriteLine("Importando artículo extranjero...");
        }
    }
}