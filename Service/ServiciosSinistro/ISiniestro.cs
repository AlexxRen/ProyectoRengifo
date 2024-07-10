using ProyectoRengifo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosSinistro
{
    public interface ISiniestro
    {
        Task<bool> AddUpdateSiniestroAsync(Siniestro siniestro);
        Task<bool> DeLeteSiniestroAsync(int idSinisestro);
        Task<Siniestro> GetSiniestroAsync(int idSinisestro);
        Task<IEnumerable<Siniestro>> GetSiniestroAsync();
    }
}
