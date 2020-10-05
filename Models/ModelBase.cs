namespace mvcRakuten.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.Design;

    
    public class ModelBase
    {
        [Required]
        [Column("create_time")]
        public DateTime create_time {get; set;}

        [Column("update_time")]
        public DateTime update_time {get; set;}

        [Required]
        [Column("enabled")]
        public bool enable {get; set;}
    }

}