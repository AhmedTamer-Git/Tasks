using Core.Interfaces;
using Core.Models;
using Infrastructure.Data.DbContexts;

namespace Infrastructure.Repositories
{
    public class TaskitemRepo : ITaskitemRepo
    {
        AssessmentDbContext _context;
        public TaskitemRepo()
        {
            _context = new AssessmentDbContext();
        }

        // basic CRUD 
        public void Add(Taskitem taskitem)
        {
            // Add to cache
            _context.Add(taskitem);
        }
        public void Update(Taskitem taskitem)
        {
            // Update to cache
            _context.Update(taskitem); //Modeified

        }
        public void Delete(Taskitem taskitem)
        {
            _context.Remove(taskitem);
        }

        public List<Taskitem> GetAll()
        {
            return _context.Tasks.ToList();
        }
        public Taskitem GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
