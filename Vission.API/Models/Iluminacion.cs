using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Iluminacion
{
    public int IluId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
