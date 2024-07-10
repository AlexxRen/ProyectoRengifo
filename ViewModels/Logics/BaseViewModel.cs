using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ProyectoRengifo.ViewModels.Logics
{
    public partial class BaseViewModel: ObservableObject
    {
        [ObservableProperty]
        public bool isbusy;
        [ObservableProperty]
        public string? tile;
    }
}
