using System;
using System.Collections.Generic;
using System.Text;

namespace Organizador.Models
{
    public class Invitado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Grupo { get; set; }
        public string? Telefono { get; set; } // El error decía que faltaba este
        public string? Alergias { get; set; }
        // Usamos esto para mostrarlo en el ListBox
        public override string ToString() => $"{Nombre} ({Grupo})";
    }

}
