using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class MetodoPago
{
    public int MetId { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<Abono> Abonos { get; set; } = new List<Abono>();
}
