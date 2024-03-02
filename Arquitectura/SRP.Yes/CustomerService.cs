namespace SRP.Yes
{
    // Responsabilidad: Manejar consultas de clientes
    public class CustomerService
    {
        private int _orderId;

        public CustomerService(int orderId)
        {
            _orderId = orderId;
        }

        public void HandleCustomerQuery(string query)
        {
            Console.WriteLine($"Handling query for order {_orderId}: {query}");
            // Lógica para manejar consultas de clientes
        }
    }
}