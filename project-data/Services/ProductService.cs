using project_data.Entities;
using project_data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_data.Services
{
    internal class ProductService
    {
        private readonly ProducRepository _producRepository; 
        private readonly CategoryService _categoryService;

        public ProductService(ProducRepository producRepository, CategoryService categoryService)
        {
            _producRepository = producRepository;
            _categoryService = categoryService;
        }

        public ProducEntity CreateProduc(string title, decimal price, string categoryName)
        {
            var categoryEntity = _categoryService.CreateCategory(categoryName);

            var producEntity = new ProducEntity
            {
                Title = title,
                Price = price, 
                CategoryId = categoryEntity.Id,
            };

            producEntity = _producRepository.Create(producEntity);
            return producEntity;
        }

        public ProducEntity GetProducById(int id)
        {
            var producEntity = _producRepository.Get(x => x.Id == id);
            return producEntity;
        }

        public IEnumerable<ProducEntity> GetProducs()
        {
            var producs = _producRepository.GetAll();
            return producs;
        }

        public ProducEntity UpdateProduc(ProducEntity producEntity)
        {
            var updatedProducEntity = _producRepository.Update(x => x.Id == producEntity.Id, producEntity);
            return updatedProducEntity;
        }

        public bool DeleteProduc(int id)
        {
            _producRepository.Delete(x => x.Id == id);
            return true;
        }
    }
}
