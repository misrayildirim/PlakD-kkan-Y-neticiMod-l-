using PlakDükkanıYöneticiModülü.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountRace { get; set; } = 0;
        public SaleStatus IsSale { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
