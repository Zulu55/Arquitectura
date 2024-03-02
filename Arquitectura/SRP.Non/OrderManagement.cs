namespace SRP.Non
{
    public class OrderManagement
    {
        private int _orderId;

        public OrderManagement(int orderId)
        {
            _orderId = orderId;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Processing order {_orderId}");
            // Lógica para procesar el pedido
        }

        public void ShipOrder()
        {
            Console.WriteLine($"Shipping order {_orderId}");
            // Lógica para enviar el pedido
        }

        public void HandleCustomerQuery(string query)
        {
            Console.WriteLine($"Handling query for order {_orderId}: {query}");
            // Lógica para manejar consultas de clientes
        }
    }
}