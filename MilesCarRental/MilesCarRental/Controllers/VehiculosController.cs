using Azure.Core.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilesCarRental.Data;
using MilesCarRental.Data.Models;

namespace MilesCarRental.Controllers
{
    [Route("Vehiculos")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        //private readonly MilesCarRentalContext _context;


        //public VehiculosController(MilesCarRentalContext context)
        //{
        //    _context = context;
        //}

        //Get: api/Vehiculos
        [HttpGet]
        [Route("Lista")]
        public dynamic GetVehiculo()
        {

            List<Vehiculo> Vehiculos = new List<Vehiculo>
            {
            new Vehiculo
                {
                    Id = 1,
                    IdLocalidadRecogida = "1",
                    IdLocalidadDevolucion = "1",
                    Marca  = "Toyota",
                    Color  = "Negro",
                    Cilindraje = "3500 cc"
            },
                new Vehiculo
                {
                    Id = 2,
                    IdLocalidadRecogida = "2",
                    IdLocalidadDevolucion = "2",
                    Marca  = "Mazda",
                    Color  = "Blanco",
                    Cilindraje = "2500 cc"
                },
                new Vehiculo
                {
                    Id = 3,
                    IdLocalidadRecogida = "1",
                    IdLocalidadDevolucion = "2",
                    Marca  ="Audi",
                    Color  ="Gris",
                    Cilindraje = "3500 cc"
                },
                new Vehiculo
                {
                    Id = 4,
                    IdLocalidadRecogida = "2",
                    IdLocalidadDevolucion = "1",
                    Marca  ="Subaru",
                    Color  ="Azul",
                    Cilindraje = "1500 cc"
                }
            };

            return Vehiculos;


        }

        //consultas por id de recogidas y devoluciones
        [HttpPost]
        [Route("Consultas")]
        public dynamic ConsultarVehiculos(string _idRecogida, string _idDevolucion)
        {
            if (_idRecogida == null && _idDevolucion == null)
            {
                return new
                {
                    Succes = false,
                    Message = "Error en la consulta",
                    result = ""
                };
            }

            switch (_idRecogida)
            {
                case "1":
                    if(_idDevolucion == "1")
                    {
                        return new Vehiculo
                        {
                            Id = 1,
                            IdLocalidadRecogida = _idRecogida,
                            IdLocalidadDevolucion = _idDevolucion,
                            Marca = "Toyota",
                            Color = "Negro",
                            Cilindraje = "3500 cc"
                        };
                    }
                    else
                    {
                        return new Vehiculo
                        {
                            Id = 3,
                            IdLocalidadRecogida = _idRecogida,
                            IdLocalidadDevolucion = _idDevolucion,
                            Marca = "Audi",
                            Color = "Gris",
                            Cilindraje = "3500 cc"
                        };
                    }
                    break;

                case"2":
                    if (_idDevolucion == "1")
                    {
                        return new Vehiculo
                        {
                            Id = 4,
                            IdLocalidadRecogida = _idRecogida,
                            IdLocalidadDevolucion = _idDevolucion,
                            Marca = "Toyota",
                            Color = "Negro",
                            Cilindraje = "3500 cc"
                        };
                    }
                    else
                    {
                        return new Vehiculo
                        {
                            Id = 2,
                            IdLocalidadRecogida = _idRecogida,
                            IdLocalidadDevolucion = _idDevolucion,
                            Marca = "Mazda",
                            Color = "Blanco",
                            Cilindraje = "2500 cc"
                        };
                    }
                    break;
                default:
                    return new
                    {
                        Succes = false,
                        Message = "No existen datos con valores ingresados",
                        result = ""
                    };
            }                                           
        }


        //    Esta parte del codigo se usaria aplicando el CodeFirts
        //public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculo()
        //{

        //    if (_context.Vehiculos == null)
        //    {
        //        return NotFound();
        //    }

        //    return await _context.Vehiculos.ToListAsync();

        //}



    }

}
