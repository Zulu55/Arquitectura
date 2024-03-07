namespace LSP.Yes
{
    public abstract class Articulo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        protected Articulo(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract double ObtenerPrecio();
    }
}