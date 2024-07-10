using ProyectoRengifo.Models;
using ProyectoRengifo.Models.Mod_Logic; // Asegúrate de tener esta línea
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosMain
{
    public class LoginService : ILogin
    {
        public async Task<UserFZT> Login(string user, string psw)
        {
            if (user == "admin" && psw == "root")
            {
                return new UserFZT { User = "admin", Psw = "root" }; // Credenciales válidas
            }
            else
            {
                return null;
            }
        }
    }
}