using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoRengifo.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRengifo.ViewModels.Rol
{
    public partial class BaseRolViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.Role ?_role;
    }
}
