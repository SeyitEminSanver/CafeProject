using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entities
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
        public string Amount { get; set; }//miktar
        public int Stock { get; set; }
        public float PrepareTime { get; set; }
    }
}
