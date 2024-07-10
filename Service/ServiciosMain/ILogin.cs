using ProyectoRengifo.Models;
using ProyectoRengifo.Models.Mod_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.Service.ServiciosMain
{
    public interface ILogin
    {
        Task<UserFZT> Login(string user, string psw);
    }
}
