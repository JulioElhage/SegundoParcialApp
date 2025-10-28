namespace SegundoParcialApp.DTOs
{
    public class OrderDTO
    {
        public int CustomerId { get; set; }   // ID del cliente
        public int ProductId { get; set; }    // ID del producto
        public DateTime OrderDate { get; set; } // Fecha en la que se realiza el pedido
        public string Status { get; set; }    // Estado del pedido (Nuevo, Enviado, Entregado, Cancelado)
    }
}