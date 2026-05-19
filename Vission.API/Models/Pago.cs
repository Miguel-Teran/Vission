using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Pago
{
    public int PagId { get; set; }

    public int? PedId { get; set; }

    public decimal? Pendiente { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<Abono> Abonos { get; set; } = new List<Abono>();

    public virtual Pedido? Ped { get; set; }
}
