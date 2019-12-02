using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.model
{
    class democontext : DbContext
    {
        public democontext() : base("Data Source=OS-20191017QIYA;Initial Catalog=sinhvien;User ID=sa;password=123")
        {

        }
        public DbSet<SinhVIen> sinhVIens { get; set; }
        public DbSet<van> vans { get; set; }
        public DbSet<cntt> cntts { get; set; }
        public DbSet<vatly> vatlies { get; set; }
    }
}
