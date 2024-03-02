namespace SRP.Yes
{
    // Responsabilidad: Manejar el envío de pedidos
    public class OrderShipper
    {
        private int _orderId;

        public OrderShipper(int orderId)
        {
            _orderId = orderId;
        }

        public void ShipOrder()
        {
            Console.WriteLine($"Shipping order {_orderId}");
            // Lógica para enviar el pedido
        }
    }
}