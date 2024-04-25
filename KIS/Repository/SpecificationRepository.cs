using KIS.Interfaces;
using KIS.Models;

namespace KIS.Repository
{
    public class SpecificationRepository : ISpecificationRepository
    {
        private readonly DBContext _context;

        public SpecificationRepository(DBContext context)
        {
            _context = context;
        }

        public List<SpecificationModel> GetAll()
        {
            return _context.Specifications.ToList();
        }

        public SpecificationModel GetById(int positionID)
        {
            return _context.Specifications.Find(positionID);
        }

        public void Add(SpecificationModel Specification)
        {
            _context.Specifications.Add(Specification);
            _context.SaveChanges();
        }

        public void Update(SpecificationModel Specification)
        {
            _context.Specifications.Update(Specification);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Specification = _context.Specifications.Find(id);
            if (Specification != null)
            {
                _context.Specifications.Remove(Specification);
                _context.SaveChanges();
            }
        }
    }
}
