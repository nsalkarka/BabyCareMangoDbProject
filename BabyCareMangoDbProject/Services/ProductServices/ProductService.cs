using AutoMapper;
using BabyCareMangoDbProject.DataAccess.Entities;
using BabyCareMangoDbProject.DataAccess.Settings;
using BabyCareMangoDbProject.Dtos.ProductDtos;
using MongoDB.Driver;

namespace BabyCareMangoDbProject.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;
        public ProductService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            _mapper= mapper;
            var client =new MongoClient(databaseSettings.ConnectionString);
            var database=client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollectionName);
        }

        public Task CreateAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateProductDto> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
