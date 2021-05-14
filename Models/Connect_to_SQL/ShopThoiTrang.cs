using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Connect_to_SQL
{
    public partial class ShopThoiTrang : DbContext
    {
        public ShopThoiTrang()
            : base("name=ShopThoiTrang")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
