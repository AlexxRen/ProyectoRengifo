using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProyectoRengifo.Models;

public partial class Role : INotifyPropertyChanged
{
    /*eventos*/
    public event PropertyChangedEventHandler? PropertyChanged;

    /*datos*/
    [PrimaryKey] public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string NivelPrivilegio { get; set; } = null!;

   /*relaciones*/
    public virtual ICollection<Agente> Agentes { get; set; } = new List<Agente>();

   
}
