using GACWarehousingApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models.DataManager
{
    public class CustomerManager : IDataRepository<SalesOrder>
    {
        readonly AppDbContext _appDbContext;

        public CustomerManager(AppDbContext context)
        {
            _appDbContext = context;
        }

        public IEnumerable<SalesOrder> GetAll()
        {
            return _appDbContext.SalesOrders.ToList();
        }

        public SalesOrder Get(int id)
        {
            return _appDbContext.SalesOrders
                  .FirstOrDefault(e => e.OrderID == id);
        }

        public void Add(SalesOrder entity)
        {
            _appDbContext.SalesOrders.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Update(SalesOrder salesOrder, SalesOrder entity)
        {
            salesOrder.ProductList = entity.ProductList;
            salesOrder.ProductQuantity = entity.ProductQuantity;
            salesOrder.OrderID = entity.OrderID;


            _appDbContext.SaveChanges();
        }

        public void Delete(SalesOrder salesOrder)
        {
            _appDbContext.SalesOrders.Remove(salesOrder);
            _appDbContext.SaveChanges();
        }

        
    }
}
