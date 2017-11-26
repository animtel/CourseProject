namespace CourseProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            Checks = new HashSet<Checks>();
            Serieses1 = new HashSet<Serieses>();
            Serieses2 = new HashSet<Serieses>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public virtual Authors Authors { get; set; }

        public virtual Serieses Serieses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checks> Checks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serieses> Serieses1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serieses> Serieses2 { get; set; }
    }
}
