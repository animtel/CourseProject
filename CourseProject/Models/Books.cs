namespace CourseProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Author { get; set; }

        [Required]
        [StringLength(50)]
        public string Publishing { get; set; }

        public int Year { get; set; }

        public int Amount { get; set; }

        [Required]
        [StringLength(10)]
        public string Price { get; set; }

        public int? SeriesId { get; set; }
    }
}
