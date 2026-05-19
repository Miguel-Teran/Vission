using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Categorium
{
    public int CatId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
