using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductIMGService : IProductIMGService
    {
        private UnitOfWork _unitOfWork;
        private IMapper _mapper;
        public void Add(ProductIMGDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            _unitOfWork.PorductIMGs.Delete(ID);
        }

        public void Edit(ProductIMGDTO entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductIMGDTO> Get()
        {
            return _mapper.Map<IEnumerable<ProductIMGDTO>>(_unitOfWork.PorductIMGs.Get());
        }

        public ProductIMGDTO Get(Guid ID)
        {
            return _mapper.Map<ProductIMGDTO>(_unitOfWork.PorductIMGs.Get(ID));
        }

        public IEnumerable<ProductIMGDTO> GetProductIMGsByProductID(Guid productID)
        {
            return _mapper.Map<IEnumerable<ProductIMGDTO>>(_unitOfWork.PorductIMGs.GetProductIMGsByProductID(productID));
        }
    }
}
