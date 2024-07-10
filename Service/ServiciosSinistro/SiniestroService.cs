using ProyectoRengifo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosSinistro
{
    public class SiniestroService : ISiniestro
    {
        public SQLiteAsyncConnection _database;
        public SiniestroService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Siniestro>().Wait();
        }

        public Task<bool> AddUpdateSiniestroAsync(Siniestro siniestro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeLeteSiniestroAsync(int idSinisestro)
        {
            throw new NotImplementedException();
        }

        public Task<Siniestro> GetSiniestroAsync(int idSinisestro)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Siniestro>> GetSiniestroAsync()
        {
            throw new NotImplementedException();
        }
    }
}
