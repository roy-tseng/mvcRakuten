namespace mvcRakuten.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.Design;

    [Table("member")]
    public class Member : ModelBase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}

        [Required]
        [Column("name")]
        public string name {get; set;}

        [Required]
        [Column("pid")]
        public string pid {get; set;}
        
        [Required]
        [Column("address")]
        public string address {get; set;}
        
        [Required]
        [Column("mobile")]
        public string mobile {get; set;}

        [Column("home")]
        public string home {get; set;}

        [Column("birthday")]
        public DateTime birthday {get; set;}
        
        [Column("gender")]
        [Required]
        public int gender {get; set;}

        [Column("id_code")]
        [Required]
        public string id_code {get; set;}

        public Member():base()
        {

        }
    }
}