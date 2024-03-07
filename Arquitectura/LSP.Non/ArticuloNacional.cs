namespace LSP.Non
{
    public class ArticuloNacional : Articulo
    {
        public ArticuloNacional(string nombre, double precio) : base(nombre, precio)
        {
        }

        public override double ObtenerPrecio()
        {
            return Precio;
        }

        public override void Importar()
        {
            // No necesita implementación para ArticuloNacional.
        }
    }
}