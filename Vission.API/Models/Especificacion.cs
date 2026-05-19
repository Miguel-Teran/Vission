using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Especificacion
{
    public int EspId { get; set; }

    public decimal? EspAnc { get; set; }

    public decimal? EspLar { get; set; }

    public decimal? EspArea { get; set; }

    public int? AcaId { get; set; }

    public virtual Acabado? Aca { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
