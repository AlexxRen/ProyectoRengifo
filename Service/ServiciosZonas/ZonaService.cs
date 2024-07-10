using ProyectoRengifo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosZonas
{
    public class ZonaService : IZona
    {
        public SQLiteAsyncConnection _database;
        public ZonaService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Zona>().Wait();
        }

        public async Task<bool> AddUpdateZonaAsync(Zona zona)
        {
            if (zona.IdZona > 0)
            {

                await _database.UpdateAsync(zona);

            }
            else
            {
                await _database.InsertAsync(zona);
            }
            return await Task.FromResult(true); ;
        }

        public async Task<bool> DeLeteZonaAsync(int IdZona)
        {
            
            await _database.DeleteAsync<Zona>(IdZona);
            return await Task.FromResult(true);
            
        }

        public async Task<Zona> GetZonaAsync(int IdZona)
        {
            return await _database.Table<Zona>().Where(p => p.IdZona == IdZona).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Zona>> GetZonaAsync()
        {
            return await Task.FromResult(await _database.Table<Zona>().ToListAsync());
        }
    }
}
