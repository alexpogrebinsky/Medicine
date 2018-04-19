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
    public class MedicationList
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
