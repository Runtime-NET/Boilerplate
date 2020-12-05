﻿using AspNetCoreHero.Boilerplate.Application.DTOs.Entities;
using AspNetCoreHero.Boilerplate.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreHero.Boilerplate.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync
    {
        IQueryable<Product> Products { get; }

        Task<List<ProductDto>> GetListAsync();

        Task<List<ProductDto>> GetSelectListAsync();

        Task<Product> GetByIdAsync(int productId);

        Task<ProductDto> GetDetailsByIdAsync(int productId);

        Task<int> InsertAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);
    }
}
