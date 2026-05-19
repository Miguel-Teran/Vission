using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Soporte
{
    public int SopId { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
