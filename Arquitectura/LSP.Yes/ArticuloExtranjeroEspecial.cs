namespace LSP.Yes
{
    public class ArticuloExtranjeroEspecial : Articulo, IImportable
    {
        public double Impuesto { get; set; }

        public ArticuloExtranjeroEspecial(string nombre, double precio, double impuesto = 0.05) : base(nombre, precio)
        {
            Impuesto = impuesto;
        }

        public override double ObtenerPrecio()
        {
            return Precio * (1 + Impuesto);
        }

        public void Importar()
        {
            Console.WriteLine("Importando artículo extranjero especial...");
        }
    }
}