using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? CodBarras { get; set; }
        public int? Cantidad { get; set; }
        public byte[] Img { get; set; }
    }
}
