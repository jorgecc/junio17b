namespace Junio17b.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Paises
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaisId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
