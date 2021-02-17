﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);                  //Id ye göre getir.
        List<Product> GetByUnitPrice(decimal min, decimal max);   //Şu aralıklarda getir.
    }
}