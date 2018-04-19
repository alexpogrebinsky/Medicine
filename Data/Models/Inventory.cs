using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Inventory
    {
        [Key]
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int Dosage { get; set; }

        public virtual List<MasterList> Description { get; set; }
    }
}
