using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.DatabaseOfMotorcycles.Repository
{
    internal interface IMotorcycleRepository<T>
    {
        List<T> GetMotorcycles();
        T GetMotorcycleByID(Guid id);
        void CreateMotorcycle(params T[] motorcycle);
        void DeleteMotorcycle(T motorcycle);
        void UpdateMotorcycle(T motorcycle);
    }
}
