using ProyectoRengifo.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = ProyectoRengifo.Models;
using CommunityToolkit.Mvvm.ComponentModel; 

namespace ProyectoRengifo.ViewModels.Person
{
    public partial class BasePersonsaViewModel : BaseViewModel
    {
        [ObservableProperty]
        public Models.Persona? _persona;
        public INavigation ? Navigation { get; set; }
    }
}
