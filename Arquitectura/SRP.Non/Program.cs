using SRP.Non;

public class Program
{
    public static void Main(string[] args)
    {
        OrderManagement orderMgmt = new OrderManagement(123);
        orderMgmt.ProcessOrder();
        orderMgmt.ShipOrder();
        orderMgmt.HandleCustomerQuery("¿Cuándo llegará mi pedido?");
    }
}