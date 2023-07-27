using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        // short int in bir düşüğü
        public short UnitsInStock { get; set; }
        // decimal para birimi
        public decimal UnitPrice { get; set; }
    }
}
