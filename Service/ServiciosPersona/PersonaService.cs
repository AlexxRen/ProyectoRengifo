using ProyectoRengifo.Models;
using ProyectoRengifo.Service.ServiciosPersona;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.Models
{
    public class PersonaService : IPersona
    {
        public SQLiteAsyncConnection _database;
        public PersonaService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database .CreateTableAsync<Persona>().Wait();
        }

        public async Task<bool> AddUpdatePersonaAsync(Persona persona)
        {
            if (persona.IdPersona >0) {

                await _database.UpdateAsync(persona);

            }
            else
            {
                await _database.InsertAsync(persona);   
            } 
            return await Task.FromResult(true);
        }

        public async Task<bool> DeLetePersonaAsync(int IdPersona)
        {
            await _database.DeleteAsync<Persona>(IdPersona);
            return await Task.FromResult(true);
        }

        public async Task<Persona> GetPersonaAsync(int idPersona)
        {
           return await _database.Table<Persona>().Where(p => p.IdPersona == idPersona).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Persona>> GetPersonaAsync()
        {
            return await Task.FromResult(await _database.Table<Persona>().ToListAsync());
        }
    }
}
