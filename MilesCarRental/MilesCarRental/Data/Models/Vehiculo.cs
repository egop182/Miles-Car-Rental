namespace MilesCarRental.Data.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string IdLocalidadRecogida { get; set; }
        public string IdLocalidadDevolucion { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Cilindraje { get; set; }
    }
}
