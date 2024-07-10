using ProyectoRengifo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosZonas
{
    internal interface IZona
    {
        Task<bool> AddUpdateZonaAsync(Zona zona);
        Task<bool> DeLeteZonaAsync(int IdZona);
        Task<Zona> GetZonaAsync(int IdZona);
        Task<IEnumerable<Zona>> GetZonaAsync();
    }
}
