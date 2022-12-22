using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entities
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int TableID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime ComeTime { get; set; }
        public DateTime LeaveTime { get; set; }
    }
}
