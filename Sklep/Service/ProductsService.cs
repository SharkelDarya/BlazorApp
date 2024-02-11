using Microsoft.EntityFrameworkCore;
using Sklep.Context;

namespace Sklep.Service
{
    public class ProductsService
    {
        private readonly ApplicationDBContext _applicationDbContext;
        public ProductsService(ApplicationDBContext applicationDBContext) 
        {
            _applicationDbContext = applicationDBContext;
        }
        
        // Dostać wszystkie produkty z bazy danych
        public async Task<List<Shared.Products>> GetAllProducts()
        {
            return  await _applicationDbContext.Products.ToListAsync();
        }

        // Dodać nowy rekord do bazy danych
        public async Task<bool> AddNewProducts(Shared.Products products)
        {
            await _applicationDbContext.Products.AddAsync(products);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Dostać products za pomocą id w bazie danych

        public async Task<List<Shared.Products>> GetProductsByCategory(string category)
        {
            return await _applicationDbContext.Products
                .Where(p => p.Categories == category)
                .ToListAsync();
        }
    }
}
