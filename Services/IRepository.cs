using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_hello.Models;

namespace aspnetcore_hello
{
    public interface IRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        
    }
}
