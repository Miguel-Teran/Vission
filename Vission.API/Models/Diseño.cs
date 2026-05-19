using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Diseño
{
    public int DisId { get; set; }

    public string? Nombre { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
