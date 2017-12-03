namespace CourseProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Authors
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string FIO { get; set; }

        public int Year { get; set; }
    }
}
