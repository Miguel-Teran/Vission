using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Pedido
{
    public int PedId { get; set; }

    public int? UsuId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Detalles { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Estado? EstadoNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Usuario? Usu { get; set; }
}
