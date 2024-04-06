using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<ProductDTO> GetById(int? id);
        public Task<ProductDTO> GetProductCategory(int? id);
        public Task Add(ProductDTO productDto);
        public Task Update(ProductDTO productDto);
        public Task Remove(int? id); 
    }
}