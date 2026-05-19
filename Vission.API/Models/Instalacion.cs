using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Instalacion
{
    public int InsId { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
