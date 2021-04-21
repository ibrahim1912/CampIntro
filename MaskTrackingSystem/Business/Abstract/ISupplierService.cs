using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierService //dağıtıcı-tedarikçi servis
    {
        void GiveMask(Person person);
    }
}
