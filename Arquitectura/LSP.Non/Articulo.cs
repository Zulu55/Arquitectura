namespace LSP.Non
{
    public abstract class Articulo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Impuesto { get; set; }

        protected Articulo(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            Impuesto = 0.0;
        }

        public abstract double ObtenerPrecio();

        public abstract void Importar();
    }
}