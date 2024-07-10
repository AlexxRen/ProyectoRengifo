using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoRengifo.Models;

public partial class Agente: INotifyPropertyChanged
{

    /*eventos*/

    public event PropertyChangedEventHandler? PropertyChanged;

    /*Datos*/
    [PrimaryKey,AutoIncrement] public int IdAgente { get; set; }

    [ForeignKey("Role")] public int IdRol { get; set; }

    [ForeignKey("Persona")] public string IdPersona { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual Persona Persona { get; set; } = null!;
    public virtual Role Role { get; set; } = null!;


    public virtual Role IdRolNavigation { get; set; } = null!;

    /*relaciones*/
    public virtual ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
}
