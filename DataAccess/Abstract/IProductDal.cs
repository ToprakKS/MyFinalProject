using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface metotları publictir kendisi public değildir.
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
