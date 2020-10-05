namespace mvcRakuten.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.Design;

    [Table("property")]
    public class Property : ModelBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}

        [Required]
        [Column("name")]
        public string name {get; set;}

        [Required]
        [Column("eid")]
        public string eid {get; set;}
        
        [Column("detail")]
        public string detail {get; set;}
        
        [Required]
        [Column("owner")]
        public string pid {get; set;}

        [Column("barcode")]
        public string barcode {get; set;}

        [Column("price")]
        public double price {get; set;}

        [Column("location")]
        [Required]
        public string location {get; set;}

        public Property():base()
        {

        }
    }
}