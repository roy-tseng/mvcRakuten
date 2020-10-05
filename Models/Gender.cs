namespace mvcRakuten.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.Design;

    [Table("gender")]
    public class Gender : ModelBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}

        [Required]
        [Column("name")]
        public string name {get; set;}

        public Gender():base()
        {

        }
    }
}