using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work.Domain.Entities
{
    public class ModelClass
    {
        public IQueryable<ServiceItem> InModel { get; set; }
        public IQueryable<ServiceItem> OutModel { get; set; }
    }
}
