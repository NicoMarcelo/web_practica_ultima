﻿using System;
using System.Collections.Generic;

namespace web_practica_ultima.Models;

public partial class AsignaturasAsignada
{
    public int Id { get; set; }

    public int AsignaturasId { get; set; }

    public int EstudiantesId { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public virtual Asignatura Asignaturas { get; set; } = null!;

    public virtual Estudiante Estudiantes { get; set; } = null!;
}