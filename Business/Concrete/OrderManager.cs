using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            //business code
            if (order.OrderName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.OrderNameInvalid);
            }
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<Order>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Order> GetById(int orderId)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(p => p.OrderId == orderId));
        }

        public IResult Update(Order order)
        {
            //business code
            if (order.OrderName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.OrderNameInvalid);
            }
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
