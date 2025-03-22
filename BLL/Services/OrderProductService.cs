using AutoMapper;
using BLL.Entities;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class OrderProductService : IOrderProductService
    {
        private IUnitOfWork _contextDb;
        private IMapper _mapper;
        public void Add(OrderProductDTO entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.OrderProducts.Add(_mapper.Map<OrderProduct>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Guid ID)
        {
            try
            {
                _contextDb.OrderProducts.Delete(ID);
                _contextDb.SaveChanges();
            }
            catch { throw; }
        }

        public void Edit(OrderProductDTO entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                _contextDb.OrderProducts.Edit(_mapper.Map<OrderProduct>(entity));
                _contextDb.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<OrderProductDTO> Get()
        {
            return _mapper.Map<IEnumerable<OrderProductDTO>>(_contextDb.OrderProducts.Get());
        }

        public OrderProductDTO Get(Guid ID)
        {
            return _mapper.Map<OrderProductDTO>(_contextDb.OrderProducts.Get(ID));
        }

        public IEnumerable<OrderProductDTO> GetAllByOrderID(Guid ID)
        {
            return _mapper.Map<IEnumerable<OrderProductDTO>>(_contextDb.OrderProducts.GetAllByOrderID(ID));
        }
    }
}
