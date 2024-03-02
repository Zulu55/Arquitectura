namespace SRP.Yes
{
    // Responsabilidad: Manejar el procesamiento de pedidos
    public class OrderProcessor
    {
        private int _orderId;

        public OrderProcessor(int orderId)
        {
            _orderId = orderId;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Processing order {_orderId}");
            // Lógica para procesar el pedido
        }
    }
}