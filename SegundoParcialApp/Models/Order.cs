namespace SegundoParcialApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // (Nuevo, Enviado, Entregado, Cancelado)
        public decimal Total { get; set; } // Total del pedido
    }
}