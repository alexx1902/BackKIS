using KIS.Models;

namespace KIS.Interfaces
{
    public interface IOrderRepository
    {
        List<OrderModel> GetAll();  
        OrderModel GetById(int ID);  
        void Add(OrderModel order);  
        void Update(OrderModel order);  
        void Delete(int id);  
             
    }
}
