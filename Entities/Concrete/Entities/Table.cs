using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entities
{
    public class Table:IEntity
    {
        public int TableId { get; set; }
        public bool Status { get; set; }
    }
}
