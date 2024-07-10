using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProyectoRengifo.Models;

[Table("Persona")]
public partial class Persona:INotifyPropertyChanged
{
    

    /*datos*/
    [PrimaryKey,AutoIncrement]
    public int IdPersona { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

   [Unique] public string Cedula { get; set; } = null!;

    [Ignore]
    public virtual ICollection<Agente> Agentes { get; set; } = new List<Agente>();
    /*eventos*/
    public event PropertyChangedEventHandler? PropertyChanged;
}
