using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class DetallePedido
{
    public int Dpid { get; set; }

    public int? PedId { get; set; }

    public int? Cantidad { get; set; }

    public int? Categoria { get; set; }

    public int? Material { get; set; }

    public int? Especificaciones { get; set; }

    public int? Diseño { get; set; }

    public int? Soporte { get; set; }

    public int? Iluminacion { get; set; }

    public int? Instalacion { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Categorium? CategoriaNavigation { get; set; }

    public virtual Diseño? DiseñoNavigation { get; set; }

    public virtual Especificacion? EspecificacionesNavigation { get; set; }

    public virtual Iluminacion? IluminacionNavigation { get; set; }

    public virtual Instalacion? InstalacionNavigation { get; set; }

    public virtual Material? MaterialNavigation { get; set; }

    public virtual Pedido? Ped { get; set; }

    public virtual Soporte? SoporteNavigation { get; set; }
}
