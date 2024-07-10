using ProyectoRengifo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosCamara
{
    public class CamaraService : ICamara
    {
        public SQLiteAsyncConnection _database;
        public CamaraService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CamaraEcu911>().Wait();
        }

        public async Task<bool> AddUpdateCamaraAsync(CamaraEcu911 camara)
        {
            if (camara.IdCamara > 0)
            {

                await _database.UpdateAsync(camara);

            }
            else
            {
                await _database.InsertAsync(camara);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeLeteCamaraAsync(int IdCamara)
        {
            await _database.DeleteAsync<CamaraEcu911>(IdCamara);
            return await Task.FromResult(true);
        }

        public async Task<CamaraEcu911> GetCamaraAsync(int IdCamara)
        {
            return await _database.Table<CamaraEcu911>().Where(p => p.IdCamara == IdCamara).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<CamaraEcu911>> GetCamaraAsync()
        {
            return await Task.FromResult(await _database.Table<CamaraEcu911>().ToListAsync());
        }
    }
}
