using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;


namespace Data.Models
{
    public class MasterList
    {


        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
