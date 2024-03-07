using LSP.Yes;

internal class Program
{
    private static void Main(string[] args)
    {
        var articulo1 = new ArticuloExtranjero("iPhone 15", 4800000);
        var articulo2 = new ArticuloExtranjeroEspecial("iPhone 15 Plus", 5500000);
        var articulo3 = new ArticuloNacional("Aguacate", 5200);
        var articulos = new List<Articulo>() { articulo1, articulo2, articulo3 };
        foreach (var articulo in articulos)
        {
            Console.WriteLine($"{articulo.Nombre} = {articulo.ObtenerPrecio():C2}");
        }
    }
}