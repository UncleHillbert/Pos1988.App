using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos1988.Data
{
    public class Mesa
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int QuantityPeople { get; set; }
        public Order Order { get; set; }

    }
}
