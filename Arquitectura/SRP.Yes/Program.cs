// Ejemplo de uso
using SRP.Yes;

public class Program
{
    public static void Main(string[] args)
    {
        var orderId = 123;
        var orderProcessor = new OrderProcessor(orderId);
        var orderShipper = new OrderShipper(orderId);
        var customerService = new CustomerService(orderId);

        orderProcessor.ProcessOrder();
        orderShipper.ShipOrder();
        customerService.HandleCustomerQuery("¿Cuándo llegará mi pedido?");
    }
}