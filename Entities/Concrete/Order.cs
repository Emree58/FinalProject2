using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

    }
}
// 01:37:57
//https://www.youtube.com/watch?v=Hgqqoycoh9c&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=9