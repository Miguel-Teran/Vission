using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Acabado
{
    public int AcaId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Especificacion> Especificacions { get; set; } = new List<Especificacion>();
}
