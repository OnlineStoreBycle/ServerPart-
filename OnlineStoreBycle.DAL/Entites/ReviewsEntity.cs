using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBycle.DAL.Entites
{
    internal sealed class ReviewsEntity
    {
        public int Id { get; set; }
        public string Review {  get; set; }=string.Empty;
        public int BycleId {  get; set; }
        public BycleEntity Bycle { get; set; } = new();
    }
}
