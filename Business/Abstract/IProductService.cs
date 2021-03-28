using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);                  //Id ye göre getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);   //Şu aralıklarda getir.
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);   //Product döndürüyor.
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);  //Transaction yönetemi: Uygulamalarda tutarlılığı korumak için yaptığımız bir yöntem.
    }
}
