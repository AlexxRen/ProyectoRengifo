using ProyectoRengifo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosRoles
{
    internal class RoleService : IRoles
    {
        public SQLiteAsyncConnection _database;
        public RoleService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Role>().Wait();
        }

        public async Task<bool> AddUpdateRolAsync(Role role)
        {
            if (role.IdRol > 0)
            {

                await _database.UpdateAsync(role);

            }
            else
            {
                await _database.InsertAsync(role);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeLeteRolAsync(int IdRol)
        {
            await _database.DeleteAsync<Role>(IdRol);
            return await Task.FromResult(true);
        }

        public async Task<Role> GetRolAsync(int idRol)
        {
            return await _database.Table<Role>().Where(p => p.IdRol == idRol).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Role>> GetRolAsync()
        {
            return await Task.FromResult(await _database.Table<Role>().ToListAsync());
        }
    }
}
