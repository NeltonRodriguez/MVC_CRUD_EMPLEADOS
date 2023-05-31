using System;
using System.Collections.Generic;

namespace MVC_CRUD_EMPLEADOS.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? FechaEmpleado { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public string? Direccion { get; set; }

    public bool ResideEnRd { get; set; }
}
