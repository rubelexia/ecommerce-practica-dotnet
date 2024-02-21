using Ecommerce.DTO;

namespace Ecommerce.WebAssembly.Servicios.Contrato
{
    public interface ICarritoServicio
    {
        event Action MostrarItems;

        int CantidadProductos();

        Task AgregarCarrito(CarritoDTO modelo);

        Task EliminarCarrito(int idProducto);

        Task<List<CarritoDTO>> DevolverCarrito();

        Task LimpiarCarrito();
    }
}
