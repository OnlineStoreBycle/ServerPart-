using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBycle.DAL.Entites
{
    internal sealed class BrandBycleEntity
    {
        public int Id {  get; set; }
        public string BrandName { get; set; }
        public IEnumerable<BycleEntity>? Bycles { get; set; }
    }
}
