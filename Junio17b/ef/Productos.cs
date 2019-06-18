namespace Junio17b.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductoId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public decimal? Precio { get; set; }

        public int? Cantidad { get; set; }
    }
}
