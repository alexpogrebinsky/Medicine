using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data.Models
{
   public class Context : DbContext
    {

   

    public Context() : base("name=Context")
    {
        this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
    }

    public System.Data.Entity.DbSet<Data.Models.Inventory> Inventories { get; set; }
    public DbSet<Data.Models.MasterList> Lists { get; set; }
}

}