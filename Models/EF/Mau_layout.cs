namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mau_layout
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Mamau { get; set; }
    }
}
