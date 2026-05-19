using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Material
{
    public int MatId { get; set; }

    public string? MatNombre { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
