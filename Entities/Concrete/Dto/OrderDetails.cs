using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto
{
    public class OrderDetails:IDto
    {
        public string ProductName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
