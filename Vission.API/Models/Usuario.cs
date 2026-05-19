using System;
using System.Collections.Generic;

namespace Vission.API.Models;

public partial class Usuario
{
    public int UsuId { get; set; }

    public string? UsuNombre { get; set; }

    public string? UsuTelefono { get; set; }

    public string? UsuDireccion { get; set; }

    public string? UsuCorreo { get; set; }

    public string? UsuContraseña { get; set; }

    public int? UsuRol { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Rol? UsuRolNavigation { get; set; }
}
