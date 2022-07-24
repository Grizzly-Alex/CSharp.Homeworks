using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.DatabaseOfMotorcycles.Repository
{
    internal abstract class BaseEntity
    {
        protected virtual Guid Id { get; set; }

        public abstract Guid GetId();
    }
}
