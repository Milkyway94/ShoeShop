namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slider")]
    public partial class Slider
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(250)]
        public string CreateBy { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyBy { get; set; }

        public bool? Status { get; set; }
    }
}
