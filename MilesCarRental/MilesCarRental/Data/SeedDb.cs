

using Azure.Core.Pipeline;

namespace MilesCarRental.Data
{
    public class SeedDb
    {
        private readonly MilesCarRentalContext context;

        public SeedDb(MilesCarRentalContext context)
        {
            this.context = context;
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Vehiculos.Any())
            {
                this.AddVehiculo(1, "1", "2", "Toyota", "Negro", "3500 cc");
                this.AddVehiculo(2, "1", "3", "Mazda", "Blanco", "2500 cc");
                this.AddVehiculo(3, "2", "1", "Audi", "Gris", "3500 cc");
                this.AddVehiculo(4, "2", "3", "Subaru", "Azul", "1500 cc");
                this.AddVehiculo(5, "3", "1", "Nissan", "Rojo", "2500 cc");
                this.AddVehiculo(6, "3", "2", "Chevrolet", "Naranja", "1800 cc");
                this.AddVehiculo(7, "1", "1", "Suzuki", "Plateado", "1600 cc");
                this.AddVehiculo(8, "2", "2", "Mercedez", "Morado", "4500 cc");
                this.AddVehiculo(8, "3", "3", "BMW", "Verde", "5500 cc");
            }
        }

        private void AddVehiculo(int id, string idRecogida, string idDevolucion, string marca, string color, string cilindraje)
        {
            this.context.Vehiculos.Add(new Models.Vehiculo
            {
                Id = id,
                IdLocalidadRecogida = idRecogida,
                IdLocalidadDevolucion = idDevolucion,
                Marca = marca,
                Color  = color,
                Cilindraje = cilindraje
            });
        }

    }
}
