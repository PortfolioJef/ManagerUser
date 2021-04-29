using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime DateInclude { get; set; }
        public DateTime DateChange { get; set; }
        public bool status { get; set; }
        public string Pass { get; set; }
    }
}
