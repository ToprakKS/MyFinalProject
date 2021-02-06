using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //Kategori ile ilgili dış dünyaya neyi servis etmek istiyorsam onu buraya yazıyorum.
        
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
