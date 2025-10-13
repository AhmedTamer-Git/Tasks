using Core.Models;


namespace Core.Interfaces
{
    public interface ITaskitemRepo
    {
        public void Add(Taskitem task);
        public void Update(Taskitem task);
        public void Delete(Taskitem task);

        public List<Taskitem> GetAll();
        public Taskitem GetById(int id);

        public void Save();
    }
}
