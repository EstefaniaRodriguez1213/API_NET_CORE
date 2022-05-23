namespace APINETCORE.Modelo
{
    public class Producto
    {
        public int Id { get; set; }

        public string? Nombre_Producto { get; set; }

        public double Precio_Venta { get; set; }

        public double Precio_Compra { get; set; }

        public int Stock { get; set; }
    }
}
