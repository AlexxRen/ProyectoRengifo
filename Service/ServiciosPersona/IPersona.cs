using ProyectoRengifo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoRengifo.Service.ServiciosPersona
{
    public interface IPersona
    {
        Task<bool> AddUpdatePersonaAsync(Persona persona);
        Task<bool> DeLetePersonaAsync(int IdPersona);
        Task<Persona> GetPersonaAsync(int IdPersona);
        Task<IEnumerable<Persona>> GetPersonaAsync();
    }
}
