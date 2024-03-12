using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBycle.DAL.Entites
{
    internal sealed class FrameSizeEntity
    {
        public int Id {  get; set; }
        public int Size { get; set; }
        public IEnumerable<BycleEntity>? Bycles { get; set; }
    }
}
