using KIS.Models;

namespace KIS.Interfaces
{
    public interface ISpecificationRepository
    {
        List<SpecificationModel> GetAll();  
        SpecificationModel GetById(int positionID);  
        void Add(SpecificationModel Specification);  
        void Update(SpecificationModel Specification);  
        void Delete(int id);  
    }
}
