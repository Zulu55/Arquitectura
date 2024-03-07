namespace LSP.Yes
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
    }
}