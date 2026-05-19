using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Abono
{
    public int AboId { get; set; }

    public int? PagId { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? Fecha { get; set; }

    public int? MetodoPado { get; set; }

    public virtual MetodoPago? MetodoPadoNavigation { get; set; }

    public virtual Pago? Pag { get; set; }
}
