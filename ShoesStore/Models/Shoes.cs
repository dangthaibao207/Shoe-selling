namespace ShoesStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shoes
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public decimal? Price { get; set; }

        [StringLength(500)]
        public string Hang { get; set; }

        [StringLength(250)]
        public string Image { get; set; }
        [ForeignKey("Category")] 
        public int CateId { get; set; }
        public virtual Category Category { get; set; }
    }
}
