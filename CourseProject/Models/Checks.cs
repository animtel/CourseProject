namespace CourseProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Checks
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Book_Id { get; set; }

        public int Reader_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Date { get; set; }

        //public virtual Books Books { get; set; }

        //public virtual Readers Readers { get; set; }
    }
}
