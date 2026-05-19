using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Estado
{
    public int EstId { get; set; }

    public string? EstPedido { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
